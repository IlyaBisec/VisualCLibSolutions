#include "MainGUIWindow.h"
#include <CommCtrl.h>


// MainForm
int WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPSTR args, int ncmdShow)
{
	WNDCLASS MainGuiClass = MainWindowClass((HBRUSH)COLOR_WINDOW, LoadCursor(NULL, IDC_ARROW), hInst, LoadIcon(NULL, IDI_WINLOGO),
		L"MainWindowClass", MainWindowProcedure);

	if (!RegisterClassW(&MainGuiClass)) { return -1; }
	MSG MainGuiMessage = { 0 };

	CreateWindow(L"MainWindowClass", L"Info Application", WS_OVERLAPPEDWINDOW | WS_VISIBLE, 300, 300, 600, 450, NULL, NULL, NULL, NULL);


	while (GetMessage(&MainGuiMessage, NULL, NULL, NULL))
	{
		TranslateMessage(&MainGuiMessage);
		DispatchMessage(&MainGuiMessage);
	}
	
	UnregisterClass(MainGuiClass.lpszClassName, hInst);
	return 0;
}

// MainFormClass
WNDCLASS MainWindowClass(HBRUSH BGColor, HCURSOR Cursor, HINSTANCE hInst, HICON Icon, LPCWSTR Name, WNDPROC Procedure)
{
	WNDCLASS MainWindowClass = { 0 };

	MainWindowClass.hIcon = Icon;
	MainWindowClass.hCursor = Cursor;
	MainWindowClass.hIcon = Icon;
	MainWindowClass.lpszClassName = Name;
	MainWindowClass.hbrBackground = BGColor;
	MainWindowClass.lpfnWndProc = Procedure;

	return MainWindowClass;
}

// If we import classes from DLL
//typedef Informator *(*CreateInformatorClass)();
//typedef void (*DeleteInformatorClass)(Informator *);

// Function prototype from DLL
typedef int(__cdecl *GetInfoFunc)(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam, HWND memo);

// Main form window procedure
// manage the state of the main window
HRESULT CALLBACK  MainWindowProcedure(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	HINSTANCE hDLL = LoadLibrary(L"DLL5.dll");
	if (hDLL == NULL) 
	{
		DWORD errorCode = GetLastError();

		MessageBox(NULL, L"Error loading the DLL, please check for DLL5", L"DLL Error", MB_OK | MB_ICONERROR);

		ExitProcess(errorCode);
	}

	switch (message)
	{
	case WM_COMMAND:
		if (LOWORD(wParam) == OnBtSelectFileClicked)
		{
			MainGuiSelectFileClicked(hDLL, hwnd, message, wParam, lParam, textboxMemo);


			//if (hDLL != NULL)
			//{
			//	// Getting the address of the exported function
			//	CreateInformatorClass createFunc = (CreateInformatorClass)GetProcAddress(hDLL, "CreateInformatorClass");
			//	DeleteInformatorClass deleteFunc = (DeleteInformatorClass)GetProcAddress(hDLL, "DeleteInformatorClass");

			//	if (createFunc != NULL && deleteFunc != NULL)
			//	{
			//		// Creating an instance of the class
			//		Informator *info = createFunc();
			//		if (info != NULL)
			//		{
			//			// Call 
			//			info->getInfo(hwnd, message, wParam, lParam);

			//			deleteFunc(info);
			//		}
			//	}
			//	FreeLibrary(hDLL);
			//}
		}
		break;
	case OnBtExitClicked:
		break;
	case WM_CREATE:
		MainGuiWidgets(hwnd);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_CLOSE:
		DestroyWindow(hwnd);
		ExitProcess(1);
		break;

		default: return DefWindowProc(hwnd, message, wParam, lParam);
	}

}


// Widgets - add controls
void MainGuiWidgets(HWND hWnd)
{
	//labels
	labelX1 = CreateWindowEx(0, WC_STATIC, L"Output", WS_CHILD | WS_VISIBLE, 12, 20, 820, 130, hWnd, nullptr, nullptr, nullptr);
	
	// Button 'Select file'
	HWND button = CreateWindow(L"BUTTON",
		L"Select file",
		WS_BORDER | WS_VISIBLE | WS_CHILD,
		125, 370, 250, 24,
		hWnd,
		(HMENU)OnBtSelectFileClicked,
		NULL,
		NULL);

	// WC_EDIT Memo
	textboxMemo = CreateWindowEx(0, L"EDIT", NULL, WS_CHILD | WS_VISIBLE | WS_BORDER | ES_MULTILINE | ES_AUTOVSCROLL | ES_READONLY,
		10, 50, 500, 300, hWnd, NULL, NULL, NULL);
}

// Event Select file button
void MainGuiSelectFileClicked(HINSTANCE hDLL, HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam, HWND memo)
{
	GetInfoFunc getInfoFunc = (GetInfoFunc)GetProcAddress(hDLL, "getInfo");

	if (getInfoFunc == NULL)
	{
		MessageBox(hwnd, L"Load function addres error", L"Error", MB_OK);
		//return 1;
	}

	int result = getInfoFunc(hwnd, msg, wParam, lParam, memo);

	FreeLibrary(hDLL);
}
