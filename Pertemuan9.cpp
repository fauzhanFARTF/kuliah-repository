#include <iostream>
using namespace std;
int main(){
 	double tot_beli, potongan=0, jum_bayar=0;
    cout << "==========================================\n";
  	cout << "Program Menghitung Potongan\n";
  	cout << "==========================================\n"<<endl;
    cout << "Total Pembelian : Rp. "; cin >> tot_beli;
    if(tot_beli>50000)
       potongan=0.2*tot_beli;
    else
    potongan=0.05*tot_beli;
    cout<< "Besarnya Potongan : Rp." << potongan << endl;
    jum_bayar=tot_beli-potongan;
    cout<<"--------------------------------------"<<endl;
    cout<<"Jumlah yang hrus dibayarkan : Rp. "<<jum_bayar;  
}