using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_operatorok
{
    internal class Szamok
    {
        public List<int> SzamLista;
        public Szamok(int[] szamok)
        {
            SzamLista = new List<int>(szamok);
        }
        public static Szamok operator +(Szamok a, Szamok b)
        {
            List<int> ujLista = new List<int>();
            ujLista.AddRange(a.SzamLista);
            ujLista.AddRange(b.SzamLista);
            return new Szamok(ujLista.ToArray());
        }
        public static Szamok operator +(Szamok a, int b)
        {

            a.SzamLista.Add(b);
            return new Szamok(a.SzamLista.ToArray());
        }
        public static int operator +(int a, Szamok b)
        {

            return a + b.SzamLista.Sum();
        }
        public static Szamok operator -(Szamok a, Szamok b)
        {
            List<int> ujLista = new List<int>(a.SzamLista);
            for (int i = 0; i < b.SzamLista.Count; i++)
            {
                ujLista.Remove(b.SzamLista[i]);
            }
            return new Szamok(ujLista.ToArray());
        }
        public static Szamok operator -(Szamok a, int b)
        {
            a.SzamLista.Remove(b);
            return new Szamok(a.SzamLista.ToArray());
        }
        public static int operator -(int a, Szamok b)
        {
            return a - b.SzamLista.Sum();
        }
        public static Szamok operator *(Szamok a, Szamok b)
        {
            List<int> ujLista = new List<int>();
            try
            {
                for (int i = 0; i < a.SzamLista.Count; i++)
                {
                    ujLista.Add(a.SzamLista[i] * b.SzamLista[i]);
                }
            }
            catch (Exception)
            {
                
            }
            return new Szamok(ujLista.ToArray());
        }
        public static Szamok operator *(Szamok a, int b)
        {
            List<int> ujLista = new List<int>();
            for (int i = 0; i < a.SzamLista.Count; i++)
            {
                ujLista.Add(a.SzamLista[i] * b);
            }
            return new Szamok(ujLista.ToArray());
        }
        public static int operator *(int a, Szamok b)
        {
            
            return a*b.SzamLista.Sum();
        }
        public override string ToString()
        {
            return string.Join(", ", SzamLista);
        }
    }
}
