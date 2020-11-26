#include <iostream>
using namespace std;
int main(){
    int luas_segitiga, alas, tinggi;
    cout << "Program Perhitungan Luas segitiga"<<endl;
    cout << "Masukan Nilai Alas : "; cin>>alas;
    cout << "Masukan Nilai Tinggi : "; cin>>tinggi;
    luas_segitiga= 0.5*alas*tinggi;
    cout<<endl<<endl;
    cout << "Hasil Perhitungan Luas segitiga = " << luas_segitiga << endl;
    return 0;
}