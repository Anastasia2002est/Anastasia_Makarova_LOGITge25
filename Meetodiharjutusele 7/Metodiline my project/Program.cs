namespace MeetodidMakarova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KuvaTervitus();

            double[] arvud = [500000.1, 100.567, 12.345, 6.66, 0.00033];

            double jagamiseTulemus = ArvutaMassiiv(arvud);

            Console.WriteLine($"Lõpptulemus on {jagamiseTulemus}");
            Console.WriteLine("Kasutasime ära kõik arvud, Let's go edasi.");

            Console.WriteLine("Kirjuta palun enda perekonnanimi:");

            string perekonnaNimi = Console.ReadLine() ?? "";

            int aTahtedeArv = LoendaATahed(perekonnaNimi);

            Console.WriteLine($"Su perekonnanimi sisaldab \"a\" tähte {aTahtedeArv} korda!");

            Console.WriteLine("Mitu km oled täna jalgsi käinud? Kirjuta täisarvuga");

            if (int.TryParse(Console.ReadLine(), out int labitudKilomeetrid))
            {
                string tagasiside = AnnaKauguseKommentaar(labitudKilomeetrid);

                Console.WriteLine(tagasiside);
            }
            else
            {
                Console.WriteLine("Palun sisesta korrektne täisarv.");
            }
        }

        private static double ArvutaMassiiv(double[] arvud)
        {
            double tulemus = arvud[0];

            Console.WriteLine($"Su esimene arv on {tulemus}");

            for (int i = 1; i < arvud.Length; i++)
            {
                Console.WriteLine($"Me jagame seda {arvud[i]}'ga");

                Console.WriteLine($"Sinu tehe on: {tulemus}/{arvud[i]}={tulemus / arvud[i]}");

                tulemus = tulemus / arvud[i];
            }

            return tulemus;
        }

        private static string AnnaKauguseKommentaar(int labitudKilomeetrid)
        {
            string tagasiside = "";

            if (labitudKilomeetrid < 0)
            {
                tagasiside = "Vigane sisend";
            }
            else if (labitudKilomeetrid == 0)
            {
                tagasiside = "Paigalseisuga tervist ei hoia";
            }
            else if (labitudKilomeetrid > 0 && labitudKilomeetrid < 5)
            {
                tagasiside = "Tubli tulemus, kontorirotid tavaliselt nii palju ei liigu";
            }
            else if (labitudKilomeetrid >= 5 && labitudKilomeetrid < 10)
            {
                tagasiside = "Pool linna kõnnib sellega maha";
            }
            else if (labitudKilomeetrid >= 10 && labitudKilomeetrid < 15)
            {
                tagasiside = "Wow, see võtab üksjagu aega";
            }
            else
            {
                tagasiside = "Ära kiirusta!!! >_<";
            }

            return tagasiside;
        }

        private static int LoendaATahed(string perekonnaNimi)
        {
            int aTahtedeArv = 0;

            foreach (char taht in perekonnaNimi.ToLower())
            {
                if (taht == 'a')
                {
                    aTahtedeArv++;
                }
            }

            return aTahtedeArv;
        }

        private static void KuvaTervitus()
        {
            Console.WriteLine("Tere hommikust!");
        }
    }
}