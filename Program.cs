using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiProgram3412
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan Karyawan1 = new Karyawan(190302123, "Paijo", 5000000);
            Karyawan Karyawan2 = new Karyawan(190302124, "Jono", 1000000);

            Console.WriteLine("Nik \t  \t Nama \t Gaji");
            Console.WriteLine("------------------------------------------");
            Karyawan1.shownKaryawan();
            Karyawan2.shownKaryawan();

            Console.WriteLine("\n Selamat Anda mendapatkan kenaikan gaji 10% \n");

            Console.WriteLine("Nik \t  \t Nama \t Gaji");
            Console.WriteLine("------------------------------------------");
            Karyawan1.naikgaji();
            Karyawan2.naikgaji();


            Console.ReadKey();
        }
    }
}
