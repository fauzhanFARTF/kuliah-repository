#include<iostream>
using namespace std;
int main(){
    cout<<endl;
    cout << "=======================================================================\n";
  	cout << "Program Menghitung rata-rata dari 5 bilangan\n";
  	cout << "=======================================================================\n"<<endl;
    int k;
    float nilai, jumlah, rata2;
    jumlah=0;
    cout<<"Masukan Inputan 5 Bilangan : \n";
    for(k=1; k<=5; k++){
        cout<<"Bilangan ke- "<<k<<" : "; cin>>nilai;
        jumlah=jumlah+nilai;
    }
    rata2=jumlah/5;
    cout<<endl;
    cout<<"Rata-Rata nilai dari 5 bilangan tersebut adalah "<< rata2<<endl;
}
