﻿namespace PGM2_cviceni2_obdelnik.Model
{
    public class Obdelnik
    {
        public int StranaA { get; set; }
        public int StranaB { get; set; }
        public int Obvod { get; set; }
        public int Obsah { get; set; }
        public double Uhlopricka { get; set; }

        private void SpoctiObsah()
        {
            Obsah = StranaA * StranaB;
        }

        private void SpoctiObvod()
        {
            Obvod = 2 * (StranaA + StranaB);
        }

        private void SpoctiUhlopricku()
        {
            Uhlopricka = Math.Sqrt(StranaA * StranaA + Math.Pow(StranaB, 2));
        }

        public void Vypocet()
        {
            SpoctiObsah();
            SpoctiObvod();
            SpoctiUhlopricku();
        }
    }
}
