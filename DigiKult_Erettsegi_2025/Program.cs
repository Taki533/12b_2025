﻿namespace DigiKult_Erettsegi_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("ut.txt");
            List<ADATOK> adatLista = new List<ADATOK>();
            int fullLength = int.Parse(sorok[0]);
            for (int i = 1; i < sorok.Length; i++)
            {
                adatLista.Add(new ADATOK(sorok[i]));
            }
        }
    }
}
