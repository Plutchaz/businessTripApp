using System;
using System.Collections.Generic;
using System.Text;

namespace businessTripApp
{
    public class BusinessTrip : Project //-> inherit dari project karena business trip tergantung project
    {
        public BusinessTrip(int id, int durasi, string lokasi)
        {
            Id = id;
            Durasi = durasi;
            Lokasi = lokasi;
        }

        public int id { get; protected set; }
        public int durasi { get; protected set; }
        public string lokasi { get; protected set; }

    }
}
