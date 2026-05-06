namespace TsüklidKontrolltööMakarova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ÜLESANNE 1:");

            int inimeseVanus = 0;

            do
            {
                Console.WriteLine("Kui vana sa oled?");
                inimeseVanus = int.Parse(Console.ReadLine());
            }
            while (inimeseVanus > 0);

            Console.WriteLine("---=== Vajuta enter et näha järgmist ülesannet ===---");
            Console.ReadLine();

            Console.WriteLine("ÜLESANNE 2:");

            int sisestatudAasta = 1000;

            while (sisestatudAasta > 999 && sisestatudAasta < 2026)
            {
                Console.WriteLine("Palun sisesta aastaarv:");
                sisestatudAasta = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("---=== Vajuta enter et näha järgmist ülesannet ===---");
            Console.ReadLine();

            Console.WriteLine("ÜLESANNE 3:");

            List<string> puuviljadeNimekiri = new List<string>()
            {
                "KaisuKiivi",
                "PlahvatavPapaia",
                "ÕudusÕun",
                "MegaMango",
                "ArmasApelsin"
            };

            Console.WriteLine("Kingiideed:");

            for (int indeks = 0; indeks < puuviljadeNimekiri.Count; indeks++)
            {
                Console.WriteLine($"{indeks + 1}) {puuviljadeNimekiri.ElementAt(indeks)}");
            }

            Console.WriteLine("---=== Vajuta enter et näha järgmist ülesannet ===---");
            Console.ReadLine();

            Console.WriteLine("ÜLESANNE 4:");

            List<int> arvudeList = new List<int>() { 3, 5, 7, 4, 6 };

            int korrutiseTulemus = 1;

            foreach (int arv in arvudeList)
            {
                Console.WriteLine($"{korrutiseTulemus} korda {arv} on {korrutiseTulemus * arv}");

                korrutiseTulemus = korrutiseTulemus * arv;
            }
        }
    }
}