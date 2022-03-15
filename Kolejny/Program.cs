// See https://aka.ms/new-console-template for more information
using System;

namespace Kolejny // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek czlowiekAdam = new Czlowiek("Adam","Szpadel",30);
            Czlowiek pusty = new Czlowiek("","",0);
            Console.WriteLine("Adam nazywa się teraz: " + czlowiekAdam.imie + " i ma lat: " + czlowiekAdam.wiek);
            Console.WriteLine("Pusty ma na imię: " + pusty.imie + " i ma lat: " + pusty.wiek);

            Mebel krzeslo = new Mebel();
            krzeslo.Sztuk = 10;
            Console.WriteLine($"Mamy aktualnie krzeseł w ilości {krzeslo.Sztuk}");

            Console.ReadKey();

        }
    }


}
