using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2320
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kry = new Karyawan();
            kry.Nik = "123456";
            kry.Nama = "Tejo";
            kry.GajiBulanan = 3000000;

            Karyawan kry2 = new Karyawan();
            kry2.Nik = "123456";
            kry2.Nama = "Surti";
            kry2.GajiBulanan = 2000000;

            if (kry.GajiBulanan < 0)
               kry.GajiBulanan = 0;

            if (kry2.GajiBulanan < 0)
               kry2.GajiBulanan = 0;

            Console.WriteLine("No Nik\tKaryawan\tGaji Bulanan");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. {0}\t{1}\t{2}",kry.Nik, kry.Nama,kry.GajiBulanan  );
            Console.WriteLine("2. {0}\t{1}\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

            Console.WriteLine("");
            Console.WriteLine("asyikkk kenaikan Gaji 10%");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("No Nik\tKaryawan\tGaji Bulanan");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. {0}\t{1}\t{2}", kry.Nik, kry.Nama, kry.GajiBulanan + kry.GajiBulanan *0.10 );
            Console.WriteLine("2. {0}\t{1}\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan + kry.GajiBulanan * 0.10);
            Console.ReadKey();
        }
    }
}
