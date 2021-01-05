#include <iostream>
using namespace std;
int main(){
 	int x, y, z;
    cout << "==========================================\n";
  	cout << "Program Menghitung Bilangan Terbesar\n";
  	cout << "==========================================\n"<<endl;
    cout << "Nilai x ? "; cin >> x;
    cout << "Nilai y ? "; cin >> y;
    cout << "Nilai z ? "; cin >> z;
    
    if((x>y)&&(x>z))
    cout << "Bilangan Terbesar Adalah " << x << endl;
	else if((y>x)&&(y>z))
    cout << "Bilangan Terbesar Adalah " << y << endl;
    else
    cout << "Bilangan Terbesar Adalah " << z << endl; 
}
