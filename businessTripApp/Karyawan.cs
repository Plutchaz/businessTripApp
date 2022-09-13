using System;
using System.Collections.Generic;
using System.Text;

namespace businessTripApp
{
    public class Karyawan
    {
        //constructor setter getter untuk bisa isi
        public Karyawan(int Id, string Nama, bool Gender, string Departemen)
        {
            this.Id = Id;
            this.Nama = Nama;
            this.Gender = Gender;
            this.Departemen = Departemen;
        }

        public Karyawan()
        {

        }
        public int Id { get; protected set; }
        public string Nama { get; protected set; }
        public bool Gender { get; protected set; }
        public string Departemen { get; protected set; }

        //bekerja
        public void Bekerja()
        {
            Console.WriteLine(Nama + " sedang bekerja");
        }

        //meeting
        public void Meeting()
        {
            Console.WriteLine(Nama + " sedang mengikuti meeting");
        }


        //istirahat
        public void Istirahat()
        {
            Console.WriteLine(Nama + " sedang beristirahat");
        }

        //libur
        public void Cuti()
        {
            Console.WriteLine(Nama + " sedang cuti");
        }

        public void JobDesc()
        {
            string[] departemen = {"IT", "HR", "Sales", "Accounting", "QA",};

            // ini buat nunjukkin isi arraynya
            Console.WriteLine("Berikut adalah departemen dalam kantor ini: ");
            for (int i = departemen.GetLowerBound(0); i <= departemen.GetUpperBound(0); i++)
                Console.WriteLine(departemen[i]);

            Console.WriteLine("Input departemen : ");
            string input = Console.ReadLine();
            int indexDepartemen = Array.IndexOf(departemen, input);

            switch (indexDepartemen)
            {
                case 0:
                    Console.WriteLine("jobdesc pada business trip adalah sebagai berikut : \n " +
                        "\n 1. Melakukan konsultasi dengan klien " +
                        "\n 2. Membuat program yang dibutuhkan" +
                        "\n 3. Membuat dokumentasi program");
                    break;
                case 1:
                    Console.WriteLine("jobdesc pada business trip adalah sebagai berikut : \n " +
                        "\n 1. Melakukan dokumentasi kegiatan" +
                        "\n 2. Mencatat jam masuk dan kerja karyawan");
                    break;
                case 2:
                    Console.WriteLine("jobdesc pada business trip adalah sebagai berikut : \n " +
                        "\n 1. Melakukan negosiasi dengan mitra" +
                        "\n 2. Menjaga hubungan baik dengan mitra" +
                        "\n 3. Mempromosikan perusahaan");
                    break;
                case 3:
                    Console.WriteLine("jobdesc pada business trip adalah sebagai berikut : \n " +
                        "\n 1. Melakukan perhitungan anggaran business trip" +
                        "\n 2. Melakukan perhitungan terhadap estimasi project" +
                        "\n 3. Melaporkan hasil project kepada manager");
                    break;
                case 4:
                    Console.WriteLine("jobdesc pada business trip adalah sebagai berikut : \n " +
                        "\n 1. Melakukan research terhadap project " +
                        "\n 2. Melaporkan hasil kepada manager");
                    break;
                default :
                    Console.WriteLine("non-departemen");
                    break;
            }
        }
    }
}
