#include <Windows.h>
#include <tchar.h>

/*
// WinMain() ������ ����� -> ���� -> ���� Ȯ�� -> ����
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
	MessageBox(NULL, L"Hello World", L"�޽���", MB_OK);
	return 0;
}