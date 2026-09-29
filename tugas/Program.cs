using System;

namespace Tugas
{
    class Home
    {
        static void Main(string[] args)
        {
            double buku1 = 100;
            double buku2 = 200;
            double buku3 = 300;
            double pulpen = 500;
            int jumlahpulpen = 2;

            double totalpulpen = pulpen * jumlahpulpen;
            double totalbelanja = buku1 + buku2 + buku3 + totalpulpen;

            string statusDiskon = "Tidak Dapat Diskon";
            double totalAkhir = totalbelanja;


            if (totalbelanja >= 1500)
            {
                statusDiskon = "30%";
                double nilaiDiskon = totalbelanja * 0.30;   
                totalAkhir = totalbelanja - nilaiDiskon;

                Console.WriteLine("Selamat, hari ini Anda mendapatkan diskon " + statusDiskon);
            }
            else if (totalbelanja >= 1000)
            {
                statusDiskon = "20%";
                double nilaiDiskon = totalbelanja * 0.20;
                totalAkhir = totalbelanja - nilaiDiskon;

                Console.WriteLine("Selamat, hari ini Anda mendapatkan diskon " + statusDiskon);
            }
            else if (totalbelanja >= 500)
            {
                statusDiskon = "10%";
                double nilaiDiskon = totalbelanja * 0.10;
                totalAkhir = totalbelanja - nilaiDiskon;

                Console.WriteLine("Selamat, hari ini Anda mendapatkan diskon " + statusDiskon);
            }
            else
            {
                Console.WriteLine(statusDiskon);
            }
            Console.WriteLine("Total Belanja Awal: " + totalbelanja);
            Console.WriteLine("Total Bayar Akhir : " + totalAkhir);
        }
    }
}