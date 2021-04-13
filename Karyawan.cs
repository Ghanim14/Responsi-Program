using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiProgram3412
{
    class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            Nik = nik;
            Nama = nama;

            if (gaji < 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gaji;
            }

        }
        public void shownKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", Nik, Nama, GajiBulanan);
        }

        public void naikgaji()
        {
            int gaji = 0;
            gaji = 10 * GajiBulanan / 100;
            GajiBulanan += Convert.ToInt32(gaji);
            Console.WriteLine("{0} \t {1} \t {2}", Nik, Nama, GajiBulanan);
        }
    }
}
