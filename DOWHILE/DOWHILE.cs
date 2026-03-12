namespace DOWHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Ülesanne 3 */
            Console.WriteLine("Mis on sinu viimased mängimis tundid?");
            float tunde = float.Parse(Console.ReadLine());
            if (tunde < 0.00)
            {
                Console.WriteLine("kahju et sul aega mängida pole :c");
            }
            else if (tunde <= 10 && tunde >= 0)
            {
                Console.WriteLine("mõõdukas mängija, tubli");
            }
            else if (tunde <= 20 && tunde >= 10)
            {
                Console.WriteLine("natuke paljuks läheb, kodutööd kannatavad");
            }
            else if (tunde <= 40 && tunde >= 20)
            {
                Console.WriteLine("liiga palju mängid, kas sa kooli üldse nii jõuad?");
            }
            else if (tunde <= 999 && tunde >= 40)
            {
                Console.WriteLine("siin peaks juba sekkuma psühholoog");
            }
        }
    }
}
