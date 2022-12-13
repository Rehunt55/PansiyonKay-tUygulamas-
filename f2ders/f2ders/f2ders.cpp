using namespace std;
#include <iostream>

class Shape {
protected:
    int width, height;

public:
    Shape(int a = 0, int b = 0) {
        width = a;
        height = b;
    }
    virtual int area() {
        cout << "Parent class area :" << width * height << endl;
        return width * height;
    }
};
class Rectangle : public Shape {
public:
    Rectangle(int a = 0, int b = 0) :Shape(a, b) { }

    int area() {
        cout << "Rectangle class area :" << width * height << endl;
        return (width * height);
    }
};

class Triangle : public Shape {
public:
    Triangle(int a = 0, int b = 0) :Shape(a, b) { }

    int area() {
        cout << "Triangle class area :" << (width * height) / 2 << endl;
        return (width * height / 2);
    }
};

int main()
{
    int var1 = 5;
    int var2 = 12;
    int var3 = 13;
    cout << "Degisken 1in adresi" << &var1 << endl;
    cout << "Degisken 2in adresi" << &var2 << endl;
    cout << "Degisken 3in adresi" << &var3 << endl; 

        int* ptr, var = 6;

    var = 10;
    ptr = &var;

    cout << "Degisken adresi" << var << endl;
    cout << "Degisken adresi" << &var << endl;
    cout << "İşaretçinin değeri" << *ptr << endl;
    cout << "işaretcinin  değeri" << ptr << endl;
}

