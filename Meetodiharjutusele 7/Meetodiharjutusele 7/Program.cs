using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ManguSalvestus
{
    internal class Program
    {
        static string saveFile = "savegame.txt";

        static void Main(string[] args)
        {
            int raha = 100;
            int elud = 3;
            List<string> seljakott = new List<string> { "taskulamp", "võti" };
            bool veritseb = false;
            int elupunktid = 100;

            Console.WriteLine("=== MÄNG ALGAB ===");

            // Kontrollime, kas salvestusfail eksisteerib
            if (File.Exists(saveFile))
            {
                Console.Write("Leidsin salvestatud mängu. Kas soovid jätkata? (jah/ei): ");
                string vastus = Console.ReadLine().ToLower();

                if (vastus == "jah")
                {
                    var andmed = LaeMäng(saveFile);

                    raha = andmed.raha;
                    elud = andmed.elud;
                    seljakott = andmed.seljakott;
                    veritseb = andmed.veritseb;
                    elupunktid = andmed.elupunktid;

                    Console.WriteLine("Mäng laaditi edukalt.\n");
                }
                else
                {
                    File.Delete(saveFile);
                    Console.WriteLine("Alustan uut mängu.\n");
                }
            }

            bool mängKäib = true;

            while (mängKäib)
            {
                KuvaSeis(raha, elud, seljakott, veritseb, elupunktid);

                Console.WriteLine("\nVali tegevus:");
                Console.WriteLine("1 - Leia raha");
                Console.WriteLine("2 - Saa kahju");
                Console.WriteLine("3 - Lisa ese seljakotti");
                Console.WriteLine("4 - Paranda ennast");
                Console.WriteLine("Kirjuta 'exit', et mängust väljuda");

                Console.Write("Sinu valik: ");
                string sisend = Console.ReadLine().ToLower();

                if (sisend == "exit")
                {
                    mängKäib = false;

                    Console.Write("Kas soovid mängu salvestada? (jah/ei): ");
                    string saveChoice = Console.ReadLine().ToLower();

                    if (saveChoice == "jah")
                    {
                        SalvestaMäng(raha, elud, seljakott, veritseb, elupunktid, saveFile);
                        Console.WriteLine("Mäng salvestati.");
                    }
                    else
                    {
                        Console.WriteLine("Mängu ei salvestatud.");
                    }

                    Console.WriteLine("Programm lõpeb.");
                    break;
                }

                switch (sisend)
                {
                    case "1":
                        raha += 25;
                        Console.WriteLine("Leidsid 25 raha!");
                        break;

                    case "2":
                        elupunktid -= 20;
                        veritseb = true;
                        Console.WriteLine("Said 20 kahju ja hakkasid veritsema.");

                        if (elupunktid <= 0)
                        {
                            elud--;
                            elupunktid = 100;
                            veritseb = false;
                            Console.WriteLine("Kaotasid ühe elu!");

                            if (elud <= 0)
                            {
                                Console.WriteLine("Mäng läbi!");
                                mängKäib = false;
                            }
                        }
                        break;

                    case "3":
                        Console.Write("Sisesta eseme nimi: ");
                        string ese = Console.ReadLine();
                        seljakott.Add(ese);
                        Console.WriteLine($"Ese '{ese}' lisati seljakotti.");
                        break;

                    case "4":
                        elupunktid += 15;
                        if (elupunktid > 100)
                            elupunktid = 100;

                        veritseb = false;
                        Console.WriteLine("Parandasid ennast.");
                        break;

                    default:
                        Console.WriteLine("Vale valik.");
                        break;
                }
            }
        }

        static void KuvaSeis(int raha, int elud, List<string> seljakott, bool veritseb, int elupunktid)
        {
            Console.WriteLine("\n--- Mängija seis ---");
            Console.WriteLine($"Raha: {raha}");
            Console.WriteLine($"Elud: {elud}");
            Console.WriteLine($"Seljakott: {(seljakott.Count > 0 ? string.Join(", ", seljakott) : "tühi")}");
            Console.WriteLine($"Veritseb: {veritseb}");
            Console.WriteLine($"Elupunktid: {elupunktid}");
        }

        static void SalvestaMäng(int raha, int elud, List<string> seljakott, bool veritseb, int elupunktid, string failinimi)
        {
            List<string> read = new List<string>();

            read.Add($"raha {raha}");
            read.Add($"elud {elud}");
            read.Add($"seljakott {string.Join(",", seljakott)}");
            read.Add($"veritseb {veritseb}");
            read.Add($"elupunktid {elupunktid}");

            File.WriteAllLines(failinimi, read);
        }

        static (int raha, int elud, List<string> seljakott, bool veritseb, int elupunktid) LaeMäng(string failinimi)
        {
            int raha = 0;
            int elud = 0;
            List<string> seljakott = new List<string>();
            bool veritseb = false;
            int elupunktid = 0;

            string[] read = File.ReadAllLines(failinimi);

            foreach (string rida in read)
            {
                string[] osad = rida.Split(' ', 2);

                if (osad.Length < 2)
                    continue;

                string nimi = osad[0];
                string väärtus = osad[1];

                switch (nimi)
                {
                    case "raha":
                        raha = int.Parse(väärtus);
                        break;

                    case "elud":
                        elud = int.Parse(väärtus);
                        break;

                    case "seljakott":
                        if (!string.IsNullOrWhiteSpace(väärtus))
                        {
                            seljakott = väärtus.Split(',').ToList();
                        }
                        break;

                    case "veritseb":
                        veritseb = bool.Parse(väärtus);
                        break;

                    case "elupunktid":
                        elupunktid = int.Parse(väärtus);
                        break;
                }
            }

            return (raha, elud, seljakott, veritseb, elupunktid);
        }
    }
}