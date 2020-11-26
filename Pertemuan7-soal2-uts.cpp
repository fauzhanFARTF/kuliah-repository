#include <iostream>
using namespace std;
int main(){
    float s, v, t;
	cout << "==========================================\n";
  	cout << "Program Menghitung Jarak yang ditempuh\n";
  	cout << "==========================================\n"<<endl;
    cout << "Masukan Nilai Kecepatan (v) (satuan km/jam) : "; cin>>v;
    cout << "Masukan Nilai Waktu (t) (satuan jam) : "; cin>>t;
    s=v*t;
    cout<<endl<<endl;
    cout << "Jarak yang dapat ditempuh dengan kecepatan dan waktu tersebut adalah" <<endl;
    cout << "  " << s << " km" <<endl;
    return 0;
}