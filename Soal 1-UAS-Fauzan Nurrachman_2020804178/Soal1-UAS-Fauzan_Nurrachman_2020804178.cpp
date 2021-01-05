#include <iostream>
using namespace std;
int main(){
 	int a, b, c, d;
    cout <<  endl;
    cout << "=======================================================================\n";
  	cout << "Program Mencari nilai terbesar dari 4 Bilangan yang diinput di keyboard\n";
  	cout << "=======================================================================\n"<<endl;
    cout << "Masukan 4 bilangan inputan !!!\n";
    cout << "Masukan Bilangan ke-1 : "; cin >> a;
    cout << "Masukan Bilangan ke-2 : "; cin >> b;
    cout << "Masukan Bilangan ke-3 : "; cin >> c;
    cout << "Masukan Bilangan ke-4 : "; cin >> d;
    cout << endl;
    if((a>b)&&(a>c)&&(a>d))
    cout << "Bilangan Terbesar dari 4 bilangan tersebut adalah " << a << endl;
	  else if((b>c)&&(b>d))
    cout << "Bilangan Terbesar dari 4 bilangan tersebut adalah " << b << endl;
    else if(c>d)
    cout << "Bilangan Terbesar dari 4 bilangan tersebut adalah " << c << endl;
    else
    cout << "Bilangan Terbesar dari 4 bilangan tersebut adalah " << d << endl; 
}
