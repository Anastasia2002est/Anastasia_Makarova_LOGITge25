namespace ConsoleApp1
{
    internal class Program
    {
        private static double väljaSumma;

        static void Main(string[] args)
        {
            List<int> koodid = new List<int>() { 4321,1166,1182,9001,0067,1620 };
            List<double> kontod = new List<double>() { 0, -23.6d, 144d, 10512.11d, -402d, 6.70d};
            //Pangaautomaat
            Console.WriteLine("Tere tulemast Hansapanka, palun sisesta oma pin-kood: ");
            int pinKood = KoodiSisestus(koodid);
            TervitaKasutajat(pinKood);
            EsitaKontojaak(pinKood, koodid, kontod);
            Console.WriteLine("Mida sa teha soovid? Palun vali arvuga: ");
            string[] valikud = new string[] { "Vota raha valja", "pane raha sisse" };
            int valikuteArv = valikud.Length;
            for (int i = 0; i < valikud.Length; i++)
            { 
                Console.WriteLine((i+1)+". "+valikud[i]);
            }
            int kasutajaValik = Valik(new List<int> { 1,2});
            if (kasutajaValik-1 == 0)
            {
                Console.WriteLine("Kui palju raha soovid valja votta?: ");
                double valjaSumma = double.Parse(Console.ReadLine());
                while (valjaSumma < 0)
                {
                    Console.WriteLine("Negatiivset arvu sisestada ei saa, proovi uuesti: ");
                    valjaSumma = double.Parse(Console.ReadLine());
                }
                kontod = Valjavote(pinKood, koodid, kontod, valjaSumma);
            }
            if (kasutajaValik == 2)
            {
                Console.WriteLine("Kui palju raha soovid sisse panna?: ");
                double sisseSumma = double.Parse(Console.ReadLine());
                while (sisseSumma < 0)
                {
                    Console.WriteLine("Negatiivset arvu sisestada ei saa, proovi uuesti: ");
                    sisseSumma = double.Parse(Console.ReadLine());
                }
                kontod = Sissemakse(pinKood, koodid, kontod, sisseSumma);
            }
            EsitaKontojaak(pinKood, koodid, kontod);
        }

        private static List<double> Sissemakse(int filter, List<int> accounts, List<double> balances, double insertAmount)
        {
            int elementlocation = accounts.IndexOf(filter);
            balances[elementlocation] += insertAmount;
            return balances;
        }

        private static List<double> Valjavote(int filter, List<int> accounts, List<double> balances, double withdrawAmount)
        {
            int elementlocation = accounts.IndexOf(filter);
            balances[elementlocation] -= withdrawAmount;
            return balances;
        }

        public static void EsitaKontojaak(int filter, List<int> accounts, List<double> balances)
        {
            int elementlocation = accounts.IndexOf(filter);
            Console.WriteLine("Teie kontojaak on: " + balances.ElementAt(elementlocation));
        }
        public static void TervitaKasutajat(int userPin)
        {
            Console.WriteLine("Tere, " + userPin + ", oled sisenenud Hansapanga automaati");
        }
        private static int Valik(List<int> valikud)
        {
            int valik;
            do
            {
                Console.WriteLine("Sisesta oma valik: ");
                valik = int.Parse(Console.ReadLine());
            } while (!valikud.Contains(valik));
            return valik;
        }
        private static int KoodiSisestus(List<int> andmebaasiInfo)
        {
            int pinKood = 0;
            do
            {
                Console.WriteLine("Sisesta kood: ");
                pinKood = int.Parse(Console.ReadLine());
            } while (!andmebaasiInfo.Contains(pinKood));
            return pinKood;
        }
    }
}

