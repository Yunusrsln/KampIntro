﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
     class Program
    {
        static void Main(string[] args)
        {
           string  kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmisMi = true;
            double doalrDun = 7.35;
            double dolarBugun = 7.45;

            if (doalrDun> dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (doalrDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirişYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }else 
            {
                Console.WriteLine("Giriş yap butonu");           
            }

           Console.WriteLine(kategoriEtiketi);

         


        }
    }
}
