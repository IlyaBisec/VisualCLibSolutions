#pragma once
#include <windows.h> // Content API

#define OnMenuClicked 1	// For check MessageBoxA

#define OnBtSelectFileClicked 5
#define OnBtExitClicked 6


HWND labelX1 = nullptr;
HWND textboxMemo = nullptr;

LRESULT CALLBACK MainWindowProcedure(HWND hWnd, UINT msg, WPARAM wp, LPARAM lp);
WNDCLASS MainWindowClass(HBRUSH BGColor, HCURSOR Cursor, HINSTANCE hInst, HICON Icon, LPCWSTR Name, WNDPROC Procedure);

void MainGuiWidgets(HWND hWnd);
void MainGuiSelectFileClicked(HINSTANCE hDLL, HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam, HWND memo);


// WIN32 API
//https://learn.microsoft.com/ru-ru/windows/win32/learnwin32/your-first-windows-program