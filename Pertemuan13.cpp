#include<iostream>
using namespace std;
int main(){
    int k, n;
    float nilai, jumlah, rata2;
    jumlah=0;
    cout<<"Jumlah data : "; cin >> n;
    for(k=1; k<=n; k++){
        cout<<"Nilai "<<k<<" : "; cin>>nilai;
        jumlah=jumlah+nilai;

    }
    rata2=jumlah/n;
    cout<<"Rata-Rata nilai= "<< rata2<<endl;
}