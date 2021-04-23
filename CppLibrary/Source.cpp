#include <iostream>
#include <comdef.h>

/// <summary>
/// Have to specify as extern in order for outside (C#) programs to use.
/// </summary>
extern "C" __declspec(dllexport) void HelloWorld();
extern "C" __declspec(dllexport) int Add(int a, int b);
extern "C" __declspec(dllexport) bool IsLengthGreaterThanN(const char* string, int n);
extern "C" __declspec(dllexport) BSTR GetName();

void HelloWorld() {
	std:: cout << "Hello World.\n";
}

int Add(int a, int b) {
	return a + b;
}

bool IsLengthGreaterThanN(const char* string, int n) {
	return strlen(string) > n;
}

BSTR GetName() {
	return SysAllocString(L"Willem");
}
