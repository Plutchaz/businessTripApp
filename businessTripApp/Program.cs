using System;

namespace businessTripApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Consultant consultant = new Consultant(1, "Aditya", true, "IT");

            BusinessTrip businesstrip = new BusinessTrip(1, 3, "Palembang");

            consultant.JobDesc();
            Console.WriteLine();
            businesstrip.TipeBusinessTrip();
            Console.WriteLine();
            businesstrip.Transportasi();
            Console.WriteLine();
            Console.WriteLine("business trip registered");

            Console.Write(consultant.Nama);
            businesstrip.NamaProject("Astropart", "Tata");
            consultant.Konsultasi(consultant.Nama);
            Console.WriteLine(consultant.Nama + " dari departemen " + consultant.Departemen +
                " mengikuti business trip berlokasi di " + businesstrip.Lokasi);


        }
    }
}
