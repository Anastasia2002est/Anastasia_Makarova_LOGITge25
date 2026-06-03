using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // mängu andmed
        int raha = 100;
        int elud = 3;
        List<string> seljakott = new List<string>();
        bool veritseb = false;
        int hp = 100;

        // kontrollib kas save fail eksisteerib
        if (File.Exists("savegame.txt"))
        {
            Console.WriteLine("Leiti salvestus. Kas soovid jätkata? (jah/ei)");
            string vastus = Console.ReadLine();

            if (vastus.ToLower() == "jah")
            {
                var andmed = LaeMang();

                raha = andmed.Item1;
                elud = andmed.Item2;
                seljakott = andmed.Item3;
                veritseb = andmed.Item4;
                hp = andmed.Item5;

                Console.WriteLine("Mäng laaditud!");
            }
            else
            {
                Console.WriteLine("Alustad uut mängu.");
            }
        }

        Console.WriteLine("\n=== MÄNG ALGAS ===");

        // mängu loop
        while (true)
        {
            Console.WriteLine("\n------------------");
            Console.WriteLine("Raha: " + raha);
            Console.WriteLine("Elud: " + elud);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("Veritseb: " + veritseb);

            Console.WriteLine("Seljakott:");
            foreach (string item in seljakott)
            {
                Console.WriteLine("- " + item);
            }

            Console.WriteLine("\nKäsud:");
            Console.WriteLine("1 - leia raha");
            Console.WriteLine("2 - võta kahju");
            Console.WriteLine("3 - lisa item");
            Console.WriteLine("4 - ravi");
            Console.WriteLine("exit - salvesta ja välju");

            Console.Write("\nSisesta käsk: ");
            string sisend = Console.ReadLine();

            // EXIT
            if (sisend.ToLower() == "exit")
            {
                SalvestaMang(raha, elud, seljakott, veritseb, hp);
                Console.WriteLine("Mäng salvestatud.");
                break;
            }

            // LEIA RAHA
            else if (sisend == "1")
            {
                raha += 50;
                Console.WriteLine("Leidsid 50 raha!");
            }

            // VÕTA KAHJU
            else if (sisend == "2")
            {
                hp -= 20;
                veritseb = true;

                Console.WriteLine("Said kahju!");

                if (hp <= 0)
                {
                    elud--;
                    hp = 100;

                    Console.WriteLine("Kaotasid elu!");

                    if (elud <= 0)
                    {
                        Console.WriteLine("GAME OVER");
                        break;
                    }
                }
            }

            // LISA ITEM
            else if (sisend == "3")
            {
                Console.Write("Sisesta item nimi: ");
                string item = Console.ReadLine();

                seljakott.Add(item);

                Console.WriteLine(item + " lisatud seljakotti.");
            }

            // RAVI
            else if (sisend == "4")
            {
                hp = 100;
                veritseb = false;

                Console.WriteLine("Said terveks.");
            }

            else
            {
                Console.WriteLine("Tundmatu käsk.");
            }
        }
    }

    // SALVESTAMINE
    static void SalvestaMang(int raha, int elud, List<string> seljakott, bool veritseb, int hp)
    {
        List<string> read = new List<string>();

        read.Add(raha.ToString());
        read.Add(elud.ToString());
        read.Add(string.Join(",", seljakott));
        read.Add(veritseb.ToString());
        read.Add(hp.ToString());

        File.WriteAllLines("savegame.txt", read);
    }

    // LAADIMINE
    static Tuple<int, int, List<string>, bool, int> LaeMang()
    {
        string[] read = File.ReadAllLines("savegame.txt");

        int raha = int.Parse(read[0]);
        int elud = int.Parse(read[1]);

        List<string> seljakott = new List<string>();

        if (read[2] != "")
        {
            seljakott = new List<string>(read[2].Split(','));
        }

        bool veritseb = bool.Parse(read[3]);
        int hp = int.Parse(read[4]);

        return Tuple.Create(raha, elud, seljakott, veritseb, hp);
    }
}