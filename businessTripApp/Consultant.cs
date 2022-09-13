using System;
using System.Collections.Generic;
using System.Text;

namespace businessTripApp
{
    public class Consultant : Karyawan, Konsultasi //interface
    {
        public Consultant(int id, string nama, bool gender, string departemen)
        {
            Id = id;
            Nama = nama;
            Gender = gender;
            Departemen = departemen;
        }

        public int id { get; protected set; }
        public string nama { get; protected set; }
        public bool gender { get; protected set; }
        public string departemen { get; protected set; }

        public void Konsultasi(string Nama)
        {
            Console.WriteLine(Nama + " sedang melakukan konsultasi dengan klien");
        }
    }
}
