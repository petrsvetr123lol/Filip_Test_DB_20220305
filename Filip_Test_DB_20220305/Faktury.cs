using System;
namespace Filip_Test_DB_20220305
{
    public class Faktury
    {
        public int id { get; set; }
        public DateTime datum { get; set; }
        public int cislo { get; set; }
        public string odberatel { get; set; }
        public string nazev { get; set; }
        public int pocet { get; set; }
        public float cena { get; set; }

    }
}
