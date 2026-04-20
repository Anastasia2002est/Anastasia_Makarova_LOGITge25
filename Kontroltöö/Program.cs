namespace MathInput1
{
    internal class Program
    {
        public static int Nipitiri { get; private set; }

        static void Main(string[] args)
        {
            //1. kirjuta programm, mis
            //omab täisarvu muutujat vanuse jaoks
            //küsib kasutajalt tema vanust. int.Parse() üritab muuta andmeid tekstist arvuks
            //omab täisarvu muutujat aastaarvu jaoks
            //küsib kasutajalt praegust kalendriaastat. int.Parse() üritab muuta andmeid tekstist arvuks
            //omab muutujat sünniaasta jaoks, siia sisse omimstatakse tehte tulemus, kus aastaarvust lahutatakse vanus

            //2. kirjuta programm, mis
            //küsib kasutajalt tema nime
            //hoiab seda nime sõne-tüüpi muutujas
            //kuvab välja tervituse, liites juurde inimese nime

            //3. kirjuta programm, mis
            //omab muutujat kommikaal
            //omab muutujat sõpradearv
            //küsib kasutajalt mitu grammi kommi tal on
            //muutujasse kommikaal pannakse kasutaja sisestatud arv
            //küsib kasutajalt mitme inimese jaoks ta kommi ostis
            //ootab kuni kasutaja sisestab arvu, mis omistatakse muutujasse sõpradearv
            //kuvatakse välja tehe kus kommikaal jagatakse sõpradearvuga

            //4. kirjuta programm, mis
            //omab muutujat õunapuusaak
            //omab muutujat sõbersai
            //küsib kasutajalt mitu õuna ta õunapuu talle andis
            //muutujasse õunapuusaak pannakse kasutaja sisestatud arv
            //küsib kasutajalt mitu õuna ta sõber tahtis
            //ootab kuni kasutaja sisestab arvu, mis omistatakse muutujasse sõbersai
            //kuvatakse välja tehe kus õunapuusaak muutujast lahutatakse maha sõbersai,
            //ning kuvatakse koos sõnumiga "sul on nii palju õunu alles"

            //4. kirjuta programm, mis
            //omab neli täisarvu muutujat, üks ema, isa, kasutaja ja õe jaoks
            //küsib kasutajalt kasutaja pikkust
            //paneb kasutajalt saadud väärtuse õigesse muutujasse
            //küsib kasutajalt kasutaja ema pikkust
            //paneb kasutajalt saadud väärtuse õigesse muutujasse
            //küsib kasutajalt kasutaja isa pikkust
            //paneb kasutajalt saadud väärtuse õigesse muutujasse
            //küsib kasutajalt kasutaja õe pikkust
            //paneb kasutajalt saadud väärtuse õigesse muutujasse
            //programm tekitab uue muutuja, kus arvutatakse välja kasutaja perekonnaliikmete keskmine pikkus
            //kuva kasutajale tema perekonna keskmine pikkus

            //5. kirjuta programm, mis
            //omab viite muutujat: esmaspäev, teisipäev, kolmapäev, neljapäev ja reede
            //küsib kasutajalt eraldi küsimusega iga päeva kohta "mitu minutit arvutimänge mängisid"
            //peale igat küsimust, sisestab vastavasse muutujasse kasutaja poolt saadud tulemuse
            //programm teeb muutuja "ajakulu" kuhu arvutatakse liites kokku kõik nädalapäeva muutujad
            //programm teeb muutuja päevakeskmine, mis hetkel on 0;
            //muutujasse päevakeskmine arvutatakse ajakulu muutujat kasutades keskmine tehtega (ajakulu / 5)
            //programm kuvab kasutajale oma nädalase koguajakulu
            //programm kuvab kasutajale päeva keskmise ajakulu
            //programm teeb muutuja "tundidesajakulu", mille sisse pannakse tehte (ajakulu/60) tulemus
            //programm kontrollib IF abil, kas  ajakulu on 35h või suurem
            //kui on suurem, kuva hoiatus "sinu mängimisele kulub peaaegu samasugune aeg nagu tavalisel inimesel töönädalas töötamisele"
            //kui on väiksem, ära tee midagi.

            
            /* Ülesanne 3 */
            //Console.WriteLine("Mis on sinu viimased mängimis tundid?");
            //float tunde = float.Parse(Console.ReadLine());
            //if (tunde < 0.00)
            //{
            //    Console.WriteLine("kahju et sul aega mängida pole :c");
            //}
            //else if (tunde <= 10 && tunde >= 0)
            //{
            //    Console.WriteLine("mõõdukas mängija, tubli");
            //}
            //else if (tunde <= 20 && tunde >= 10)
            //{
            //    Console.WriteLine("natuke paljuks läheb, kodutööd kannatavad");
            //}
            //else if (tunde <= 40 && tunde >= 20)
            //{
            //    Console.WriteLine("liiga palju mängid, kas sa kooli üldse nii jõuad?");
            //}
            //else if (tunde <= 999 && tunde >= 40)
            //{
            //    Console.WriteLine("siin peaks juba sekkuma psühholoog");
            //}

            
            /* ülesanne 4 */
            
            //Console.WriteLine("Mis on sinu viimased jalgpallimängu tulemust?");
            //float Punkt = float.Parse(Console.ReadLine());
            //if (Punkt < 0)
            //{
            //    Console.WriteLine("PUDRUJALG OLED VÄ!?!");
            //}
            //else if (Punkt <= 1 && Punkt >= 0)
            //{
            //    Console.WriteLine("täitsa OK");
            //}
            //else if (Punkt <= 1 && Punkt >= 2)
            //{
            //    Console.WriteLine("no see juba on parem");
            //}
            //else if (Punkt <= 2 && Punkt >= 3)
            //{
            //    Console.WriteLine("WOWOWOWO MESSI MESSI MESSI");
            //}
            //else if (Punkt <= 999 && Punkt >= 40)
            //{
            //    Console.WriteLine("ei tunne sellist skoori, see liiga suur minu jaoks");
            //}




        }
    }
}
