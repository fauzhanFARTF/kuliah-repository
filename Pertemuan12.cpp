#include <iostream>
#include <conio.h>
#include <math.h>
#include <iomanip>
using namespace std;
int main(){
    int pil;
 	float panjang, lebar, luas, kel, diag;
    cout << "=======================================" << endl;
    cout << setw (5) << " "<< "MENU UTAMA" << endl; 
    cout << "=======================================" << endl;
    cout << "1. Hitung Luas          " << endl;
    cout << "2. Hitung Keliling      " << endl;
    cout << "3. Hitung Diagonal      " << endl;
    cout << "4. Keluar Program       " << endl;
    cout << "=======================================" << endl;
    cout << " Pilih Nomor menu (1/2/3/4) : "; cin>>pil;
    cout << "=======================================" << endl;
    switch (pil){
        case 1 : 
        {
            cout << "Panjang ? " ; cin >> panjang; 
            cout << "Lebar ? " ; cin >> lebar;
            luas = panjang*lebar;
            cout << "Luas Segiempat  = " << luas << endl;
            break;
        }
        case 2 : 
        {
            cout << "Panjang ? " ; cin >> panjang; 
            cout << "Lebar ? " ; cin >> lebar;
            kel = 2*(panjang+lebar);
            cout << "Keliling Segiempat  = " << kel << endl;
            break;
        }
        case 3 : 
        {
            cout << "Panjang ? " ; cin >> panjang; 
            cout << "Lebar ? " ; cin >> lebar;
            diag = sqrt((panjang*panjang) + (lebar*lebar));
            cout << "Diagonal Segiempat  = " << diag << endl;
            break;
        }
        case 4 : 
        {
            cout << "Keluar Program... bye2 " <<endl; 
            break;
        }
        default : cout << "Anda Salah memilih nomor menu !!!!";
        break;
    }
}
