using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Workaround;

//Degiskenler();
//SabitVatandas();

SelamVer("Berkay");
SelamVer("Engin");
SelamVer();
int sonuc = Topla(3,5);
int sonucV2 = Topla();

//Diziler / Arrays

string ogrenci1 = "Engin";
string ogrenci2 = "Berkay";
string ogrenci3 = "Kaan";
string ogrenci4 = "İnaç";

string[] ogrenciler = new string[3];
ogrenciler[0] = ogrenci1;
ogrenciler[1] = ogrenci2;
ogrenciler[2] = ogrenci3;

ogrenciler = new string[4];
ogrenciler[3] = ogrenci4;

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] {"Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] {"Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";

Console.WriteLine(sehirler2[0]);

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
Console.WriteLine(sayi2);

Person person = new Person();
person.FirstName= "Kaan Berkay";
person.LastName= "İNAÇ";
person.DateOfBirthYear = 2000;
person.NationalIdentity = 123;

Person person2 = new Person();
person2.FirstName = "Kaan";

//string -> referans tiptir ama deger tip olarak çalışır
//stringler -> char arraylerdir.

foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

// .net framework 2 ile birlikte 2005 yılında generic collection'lar çıktı.
// challange -> Kendini dinamik List yapını oluştur.
List<string> yeniSehirler1 = new List<string>{"Ankara 1","İstanbul 1","İzmir 1"};
yeniSehirler1.Add("Adana 1");

foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

//PttManager pttManager = new PttManager(new ForeignerManager());
//pttManager.GiveMask(person);

ISupplierService supplierService = new PttManager(new PersonManager());
supplierService.GiveMask(person2);


Console.ReadLine();


// default parametre -> isim = "Misafir" eğerki kullanıcı ismi boş geçer ve metodu kullanılırsa default parametre devreye girer.
void SelamVer(string isim = "Misafir")
{
    Console.WriteLine("Merhaba " + isim);
}

//int Topla(int sayi1 = 5, int sayi2) -> Default parametreler en son parametreler olmalıdır.
int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc);
    return sonuc;
}

void Degiskenler()
{
    // DRY -> Don't Repeat Yourself
    // Reusability
    // Kendini tekrar etmeden aynı kodu her yerde kullanmak için DRY ve Reusability kullanımı önemli.

    string mesaj = "Selam";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Berkay";
    string soyad = "İnaç";
    int dogumYili = 2000;
    long tcNo = 12345678910; // TcNo, TelNo gibi yapılar sayısal olsa dahi herhangi bir matematiksel işlem yapılmadığından dolayı string tutulmalıdır.

    Console.WriteLine(tutar * 1.18);

    Console.WriteLine(tutar * 1.18);
}

Vatandas SabitVatandas()
{
    Vatandas vatandas = new Vatandas();
    vatandas.Ad = "Berkay";
    vatandas.Soyad = "Berkay";
    vatandas.DogumYili = 2000;
    vatandas.TcNo = 12345678910;
    return vatandas;
}
