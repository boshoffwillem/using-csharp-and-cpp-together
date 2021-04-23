#include <iostream>

/// <summary>
/// Have to specify as extern in order for outside (C#) programs to use.
/// </summary>
extern "C" __declspec(dllexport) void HelloWorld();

void HelloWorld()
{
	std:: cout << "Hello World.";
}