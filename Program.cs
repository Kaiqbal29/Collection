using System;
using System.Collections.Generic;

namespace list2
{
    class Program
    {
        static void Main(string[] args)
        {
            mahasiswa mhs1 = new mahasiswa();
            mhs1.NamaMahasiswa = " Erik ";
            mhs1.Nim = "1234";

            mahasiswa mhs2 = new mahasiswa();
            mhs2.NamaMahasiswa = " Wely";
            mhs2.Nim = "1235";

            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            List<mahasiswa> list = new List<mahasiswa>();
            list.Add(mhs1);
            list.Add(mhs2);
            Console.WriteLine("Nim    Nama");
            Console.WriteLine("============");
            foreach (mahasiswa mhs in list)
            {
                Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);
            }

            Console.ReadKey();
        }
    }
}
