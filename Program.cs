using System;

namespace Variables_and_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables Types

            //Sayısal Türler(Numeric Types)

            byte a = 255;   // 1 Byte // 0,...,255(tam sayı)
            sbyte b = 127;  // 1 Byte // -128,...,127(tam sayı)

            short c = 32767; // 2 Byte // -32768,...,32767(tam sayı)
            ushort d = 65535; // 2 Byte // 0,...,65535(tam sayı)

            int e = 2147483647; // 4 Byte // -2147483648,....,2147483647(tam sayı)
            uint f = 4294967295; // 4 Byte // 0,....,4294967295(tam sayı)

            long g = 9223372036854775807; // 8 Byte // -9223372036854775808,...,9223372036854775807(tam sayı)
            ulong h = 18446744073709551615; //8 Byte // 0,...,18446744073709551615(tam sayı)
            
            float i = 5f; // 4 Byte // Sonunda "f" getirilecek. // (reel sayı)
            double u = 10D; // 8 Byte // Sonunda "d,D" getirilebilir yada getirmesenizde olur. // (reel sayı)
            decimal t = 15m; // 16 Byte // Sonunda "M,m" getirilicek. // (reel sayı)

            //Metinsel Türler
            char r = 'h'; // 2 Byte // Tek Karakteri Tutar.
            string y = "metinsel türler gelicektir"; // Sınırsız // Metin Tutar.

            // Boolean
            bool b1 = true;
            bool b2 = false;
            
            // Object(Nesne)
            object o1 = 'a';
            object o2 = "C# Programlama dili"; // Bu değişken türüne her türden veri atanabilir.
            object o3 = 50;
            object o4 = 4.3;
            

            // Degisken Dönüsümleri
            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString(); // String deger olduğu icin yan yana yazıcaktır. Cıktı 2020

            int int21 = int20 + Convert.ToInt32(str20); // Integer donusturdugu icin toplar ve sonuc 40.
            int int22 = int20 + int.Parse(str20); // Integer donusturdugu için toplar ve sonuc 40.

            // DataTime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
            string hour = DateTime.Now.ToString("HH : mm"); 
        }
    }
}
