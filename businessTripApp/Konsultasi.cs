using System;
using System.Collections.Generic;
using System.Text;

namespace businessTripApp
{
    public interface Konsultasi //interface
    {
        //konsultasi -> Optional
        public void Konsultasi(string Nama)
        {
            Console.WriteLine(Nama + " sedang melakukan konsultasi dengan klien");
        }
    }
}
