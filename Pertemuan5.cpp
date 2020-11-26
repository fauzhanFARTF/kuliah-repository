#include <iostream>
using namespace std;
int main(){
    int a,b,c,d,e,f,g;
    cout << "Masukan Nilai a "; cin>>a;
    cout << "Masukan Nilai b "; cin>>b;
    cout << "Masukan Nilai c "; cin>>c;
    d=a+4<10;
    e=b>a+5;
    f=c-3>4;
    g=e||f;
    cout<<endl<<endl;
    cout << "Program expresi or"<<endl;
    cout << "Hasil dari d=a+4<10 adalah " << d << endl;
    cout << "Hasil dari e=b>a+5 adalah " << e << endl;
	cout << "Hasil dari f=c-3>4 adalah " << f << endl;
	cout << "Hasil dari g=e||f adalah " << g << endl;
    return 0;
}
