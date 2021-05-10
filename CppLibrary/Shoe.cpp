#include <string>
#include <iostream>
#include <comdef.h>

struct Shoe {
	int id;
	BSTR color;
	double size;
	BSTR brand;

	void buy() {
		std::cout << "Successfully purchased the ";
		std::cout << color;
		std::cout << " " << brand;
		std::cout << " shoe.";
		std::cout << " Size: " << size << ".";
	}
};

extern "C" __declspec(dllexport) void BuyShoe(Shoe shoe) {
	shoe.buy();
}

extern "C" __declspec(dllexport) Shoe CreateShoe(double shoeSize) {
	Shoe newShoe = Shoe();
	newShoe.id = 2;
	newShoe.brand = SysAllocString(L"Nike");
	newShoe.color = SysAllocString(L"White");
	newShoe.size = shoeSize;
	return newShoe;
}