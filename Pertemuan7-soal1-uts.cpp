#include <iostream>
using namespace std;
int main(){
    float L, r;
    const float phi = 3.14;
	cout << "=================================\n";
  	cout << "Program Menghitung Luas Lingkaran\n";
  	cout << "=================================\n"<<endl;
    cout << "Masukan Nilai Jari-Jari Lingkaran (r) : "; cin>>r;
    L= phi*r*r;
    cout<<endl<<endl;
    cout << "Hasil Perhitungan Luas Lingkaran = " << L << endl;
    return 0;
}
