using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejny
{
    internal class Klasy
    {
    }

    public class Czlowiek
    {
        public Czlowiek(string imie_, string nazwisko_, int wiek_) // Konstruktor
        {
            imie = imie_;
            nazwisko = nazwisko_;
            wiek = wiek_;

        }
        public string imie = "Nie podano";
        public int wiek = 0;
        public string nazwisko = "Nie podano";


    }
}
