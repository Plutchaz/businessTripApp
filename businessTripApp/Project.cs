using System;
using System.Collections.Generic;
using System.Text;

namespace businessTripApp
{
    public class Project : ProyekBisnis //-> abstraction
    {
        //constructor
        public Project(int Id, int Durasi, string Lokasi)
        {
            this.Id = Id;
            this.Durasi = Durasi;
            this.Lokasi = Lokasi;
        }

        public Project()
        {

        }

        public int Id { get; protected set; }
        public int Durasi { get; protected set; }
        public string Lokasi { get; protected set; }

        public void TipeBusinessTrip()
        {
            string[] tipe = { "Priority", "Regular" };

            Console.WriteLine("Silahkan masukkan tipe business trip [Priority | Regular] : ");
            string input = Console.ReadLine();
            int indexTipe = Array.IndexOf(tipe, input);

            if (indexTipe == 0)
            {
                Console.WriteLine("Project menggunakan business trip Priority");
            }
            else if (indexTipe == 1)
            {
                Console.WriteLine("Project menggunakan business trip Regular");
            }

        }

        public void Transportasi()
        {
            string[] transportasi = {"Pesawat", "Kapal", "Mobil" };

            Console.WriteLine("Silahkan masukkan tipe business trip \n [Pesawat | Kapal | Mobil] : ");
            string input1 = Console.ReadLine();
            int indexTipe = Array.IndexOf(transportasi, input1);

            if (indexTipe == 0)
            {
                Console.WriteLine("Transportasi menggunakan Pesawat " +
                    "\n total akomodasi 5000000");
            }
            else if (indexTipe == 1)
            {
                Console.WriteLine("Transportasi menggunakan Kapal " +
                    "\n total akomodasi 3000000");
            }
            else
            {
                Console.WriteLine("Transportasi menggunakan Mobil " +
                    "\n total akomodasi 1750000");
            }
        }

    }
}
