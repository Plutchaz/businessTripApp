using System;
using System.Collections.Generic;
using System.Text;

namespace businessTripApp
{
    public abstract class ProyekBisnis
    {
        public void NamaProject(string Nama)
        {
            Console.WriteLine(" mengerjakan project " + Nama);
        }

        public void NamaProject(string Nama1, string Nama2)
        {
            Console.WriteLine(" mengerjakan project " + Nama1 + " dan " + Nama2);
        }
    }
}
