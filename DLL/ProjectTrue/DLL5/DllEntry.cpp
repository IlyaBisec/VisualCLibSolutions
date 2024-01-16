// The entry point for the DLL application
// Ilya Borisov 15.10.23

// DLL contains functions for getting information output
// about the file selected by the user (size, extension, date, etc.)

#include "pch.h"

#include "DllEnrty.h"

BOOL APIENTRY DllMain(HMODULE hModule,
    DWORD  ul_reason_for_call,
    LPVOID lpReserved
)
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

std::wstring str2wstr(const std::string &str)
{
    int size_fileCreated = MultiByteToWideChar(CP_UTF8, 0, &str[0], (int)str.size(), NULL, 0);
    std::wstring wstrTo(size_fileCreated, 0);
    MultiByteToWideChar(CP_UTF8, 0, &str[0], (int)str.size(), &wstrTo[0], size_fileCreated);
    return wstrTo;
}


// Export function
extern "C" __declspec(dllexport) int getInfo(HWND hwnd, UINT msg, WPARAM wParam,
    LPARAM lParam, HWND textMemo)
{
   
        OPENFILENAME openFile;
        char sizeFileName[MAX_PATH] = "";

        FILETIME ft_create, // Creation Time
            ft_access,      // Access time
            ft_write;       // Write time
        
        SYSTEMTIME syst_create, syst_lastWrite;

        char str_creationTime[100], str_lastWrite[100];

        //TCHAR timeBuffer[100];

        std::wstring
            wstr_fileAttInfo,
            wstr_fileAttAll,
            wstr_attReadOnly,
            wstr_attHidden,
            wstr_attDirectory,
            wstr_attArchive,
            wstr_attNormal,
            wstr_fileSize,
            wstr_fileSizeFind,
            wstr_fileCreated,
            wstr_fileChanged,
            wstr_fileOwner,
            wstr_fileInformation,
            wstr_fileSizeAndDate;


        ZeroMemory(&openFile, sizeof(openFile));

        openFile.lStructSize = sizeof(OPENFILENAME);
        openFile.lpstrTitle = L"Select file";
        openFile.hwndOwner = hwnd;
        openFile.nFilterIndex = 2;
        openFile.lpstrFilter = L"User files (*.usf)\0*.usf\0All files (*.*)\0*.*\0";
        
        openFile.lpstrFile = (LPWSTR)sizeFileName;
        openFile.nMaxFile = sizeof(sizeFileName);
        openFile.lpstrInitialDir = NULL;
        openFile.Flags = OFN_EXPLORER | OFN_FILEMUSTEXIST | OFN_HIDEREADONLY | OFN_PATHMUSTEXIST;
       
        // Get info about file
        if (GetOpenFileName(&openFile) == TRUE)
        {
            
            // Get file attributes
            DWORD fileAttributes = GetFileAttributes(openFile.lpstrFile);

            if (fileAttributes != INVALID_FILE_ATTRIBUTES)
            {
                wstr_fileAttInfo = L"File attributes: ";
                if (fileAttributes & FILE_ATTRIBUTE_READONLY)
                    wstr_attReadOnly = L"Read only";
                if (fileAttributes & FILE_ATTRIBUTE_HIDDEN)
                    wstr_attHidden = L"Hidden";
                if (fileAttributes & FILE_ATTRIBUTE_DIRECTORY)
                {
                    wstr_attDirectory = L"Directory";
                }
                if (fileAttributes & FILE_ATTRIBUTE_ARCHIVE)
                    wstr_attArchive = L"Archive";
                if (fileAttributes & FILE_ATTRIBUTE_NORMAL)
                    wstr_attNormal = L"Txt File";
                std::cout << "\n";

                
                // Get file name
                std::wstring wstr_fileName(openFile.lpstrFile);

                // Get file extension               
                std::wstring wstr_extension = wstr_fileName.substr(wstr_fileName.find_last_of(L".") + 1);

                // WIN32_FIND_DATA findFileData;
                HANDLE fileHandle = CreateFile(openFile.lpstrFile, GENERIC_READ, FILE_SHARE_READ, NULL, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, NULL);

              // fileHandle = FindFirstFile(openFile.lpstrFile, &findFileData);
               if (fileHandle != INVALID_HANDLE_VALUE)
               {
                   LARGE_INTEGER fileSize;
                   char str_fileSizeAndDate[1000];

                   //Get file time
                   GetFileTime(fileHandle, &ft_create, &ft_access, &ft_write);

                   // Creation Time conversion
                   FileTimeToSystemTime(&ft_create, &syst_create);
                   GetDateFormatA(LOCALE_USER_DEFAULT, 0, &syst_create, "yyyy-MM-dd", str_creationTime, 100);
                   GetTimeFormatA(LOCALE_USER_DEFAULT, 0, &syst_create, "HH:mm:ss", str_creationTime + 10, 100 - 10);

                   // Last write Time conversion
                   FileTimeToSystemTime(&ft_write, &syst_lastWrite);
                   GetDateFormatA(LOCALE_USER_DEFAULT, 0, &syst_lastWrite, "yyyy-MM-dd", str_lastWrite, 100);
                   GetTimeFormatA(LOCALE_USER_DEFAULT, 0, &syst_lastWrite, "HH:mm:ss", str_lastWrite + 10, 100 - 10);
     
                   // Get file size 
                   GetFileSizeEx(fileHandle, &fileSize);

                   sprintf_s(str_fileSizeAndDate, "File creation date: %s\r\nFile change date: %s\r\nSize of file: %lld bytes", str_creationTime,
                       str_lastWrite, fileSize.QuadPart);

                   // Char to conversion
                   wstr_fileSizeAndDate = str2wstr(str_fileSizeAndDate);

                   CloseHandle(fileHandle);
               }
               else { wstr_fileSizeAndDate = L"Error, not open file"; }
             

                // File owner
                DWORD buffer_size = GetFileSecurity(openFile.lpstrFile, OWNER_SECURITY_INFORMATION, NULL, 0, &buffer_size);
                if (buffer_size > 0)
                {
                    PSECURITY_DESCRIPTOR securityDescriptor = reinterpret_cast<PSECURITY_DESCRIPTOR>(malloc(buffer_size));
                    
                    if (GetFileSecurity(openFile.lpstrFile, OWNER_SECURITY_INFORMATION, securityDescriptor,
                        buffer_size, &buffer_size))
                    {
                        PSID owner_Sid = NULL;
                        BOOL owner_defaulted = FALSE;

                        if (GetSecurityDescriptorOwner(securityDescriptor, &owner_Sid, &owner_defaulted))
                        {
                            TCHAR owner_name[MAX_PATH] = { 0 };
                            DWORD owner_nameSize = sizeof(owner_name);
                            SID_NAME_USE sid_nameUse;

                            if (LookupAccountSid(NULL, owner_Sid, owner_name, &owner_nameSize,
                                NULL, NULL, &sid_nameUse))
                            {
                                wstr_fileOwner = static_cast<std::wstring> (owner_name);
                            }
                        }
                    }
                    free(securityDescriptor);
                }

                // Path to folder
                std::wstring wstr_fileFolderPath = wstr_fileName.substr(0, wstr_fileName.find_last_of(L"\\"));
               
                // For 
               /* wstr_fileInformation = wstr_fileAttInfo + L"\r\n";
                wstr_fileInformation += wstr_attReadOnly + L"\r";
                wstr_fileInformation += wstr_attHidden + L"\r";
                wstr_fileInformation += wstr_attDirectory + L"\r";
                wstr_fileInformation += wstr_attArchive + L"\r\n";*/

                wstr_fileInformation = L"File name: " + wstr_fileName + L"\r\n";
                wstr_fileInformation += L"File extension: " + wstr_extension + L"\r\n";
                wstr_fileInformation += L"Folder path: " + wstr_fileFolderPath + L"\r\n";
                wstr_fileInformation += wstr_fileSizeAndDate + L"\r\n";
                
                //wstr_fileInformation += L"File change date: " + wstr_fileChanged + L"\r\n";
               // wstr_fileInformation += L"File owner: " + wstr_fileOwner + L"\r\n";
                

                // Clear WC_EDIT -> Memo
                SetWindowTextW(textMemo, L"");

                // Output info -> Memo
                SendMessageW(textMemo, EM_REPLACESEL, FALSE, (LPARAM)wstr_fileInformation.c_str());


            }
        }
        else
        {
           // std::cout << "File selection canceled!\n";
            MessageBox(hwnd, L"File selection canceled!\nCould not get information about the file",
                L"Error", MB_OK | MB_ICONERROR);
        }

        return 0;   
}




// Export class
//extern "C" __declspec(dllexport) Informator *CreateInformatorClass()
//{
//    return new Informator();
//}
//
//extern "C" __declspec(dllexport) void DeleteInformatorClass(Informator * infobj)
//{
//    delete infobj;
//}
