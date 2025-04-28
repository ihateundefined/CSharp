#include <Windows.h>
#include <tchar.h>

/*
// WinMain() 까지만 만들고 -> 빌드 -> 오류 확인 -> 무결
int APIENTRY WinMain(
	HINSTANCE hInstance,
	HINSTANCE hPreInstance,
	LPSTR lpCmdLine,
	int nCmdShow
)
{
}
*/

int APIENTRY WinMain(
	HINSTANCE hInstance,
	HINSTANCE hPreInstance,
	LPSTR lpCmdLine,
	int nCmdShow
)
{
	MessageBox(NULL, L"Hello World", L"메시지", MB_OK);
	return 0;
}