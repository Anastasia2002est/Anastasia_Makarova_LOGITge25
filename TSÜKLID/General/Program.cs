using System.ComponentModel.Design;

namespace General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #n1. "Tervitus"
            // kirjuta programm mis,
            // - küsib tsükliga kasutajalt tema eesnime
            // - - küsitakse uuesti tühja sisendi korral
            // - küsib kasutajalt tema keskmist nime
            // - - küsitakse uuesti tühja sisendi korral
            // - küsib kasutajalt tema perekonnanime
            // - - küsitakse uuesti tühja sisendi korral
            // - tema vanust
            // - - küsitakse uuesti tühja sisendi korral
            // - ning väljastab talle tervituslause, kasutades kõiki muutujaid

            // #n2. "Minu lemmiksnäkk"
            // kirjuta programm mis
            // küsib kasutajalt mis on ta lemmiksnäkk
            // programm kontrollib tsükliga kas järjendis on snäkk olemas
            // kui tsüklis leitakse snäkk, kuva tekst koos kasutajasisendiga, "jaa :D tean seda, {snäkk} on hea"
            // kui tsükkel lõppeb ilma snäkki leidmata, kuva tekst "ei tunne kahjuks {snäkk}i :C"

            // #n3. "Metsataimede välimääraja"
            // kirjuta programm mis
            // küsib kasutajalt kas ta otsib mingit seent või marja (tsüklis)
            // kui seent, siis programm esitab seeneloendis olevad seened
            // ja küsib millise seene kohta infot infojärjendist kuvada
            // tsükkel siis käib ja otsib teisest järjendis seene infot ja kuvab selle
            // kui marja, siis programm esitab marjaloendis olevad marja
            // ja küsib millise marja kohta infot infojärjendist kuvada
            // tsükkel siis käib ja otsib teisest järjendis marja infot ja kuvab selle
            // siis küsitakse kas kasutaja tahab mõne marja kohta veel infot, ning tsükkel jätkub
            // ⭐iseseisvalt lisa juurde puude tuvastamine ⭐

            string mida = string.Empty;
            List<string> valikud = new List<string>() { "seent", "marja", "puu" };
            List<string> seeneNimed = new List<string> { "kukeseen", "puuravik", "sitaseen" };
            List<string> seeneInfod = new List<string>
            {
                "Kukeseen on kollane ja näeb välja nagu keegi oleks pasuna maha matnud ning siis mootorattaga üle sõitnud",
                "Puravik on pealt pruun ja jalg on hele. Siuke ilus punsu.",
                "Sitaseen on pruun, keerlev ja tõenäoliselt lähima koera poolt tehtud kingitus."


            };
            List<string> marjaNimed = new List<string> { "astelpaju", "muuluks", "maasikas" };
            List<string> marjaInfod = new List<string>
            {
                "Astelpalju on kollane ja näeb välja nagu keegi oleks pasuna maha matnud ning siis mootorattaga üle sõitnud",
                "Muuluks on pealt pruun ja jalg on hele. Siuke ilus punsu.",
                "Maasikas on pruun, keerlev ja tõenäoliselt lähima koera poolt tehtud kingitus."

            };


            List<string> puuNimed = new List<string> { "kask", "mänd", "tamm" };
            List<string> puuInfod = new List<string>

            {
                "Kask on kollane ja näeb välja nagu keegi oleks pasuna maha matnud ning siis mootorattaga üle sõitnud",
                "Mänd on pealt pruun ja jalg on hele. Siuke ilus punsu.",
                "Tamm on pruun, keerlev ja tõenäoliselt lähima koera poolt tehtud kingitus."

            };
            do
            {
                Console.WriteLine("Kas sa otsid seent, marja või puu?");
                mida = Console.ReadLine();
            }

            //while (mida != "sent || mida != "marja");
            //while (!new List<string>() { "seent", "marja" }. Containd(mida));
            while (!valikud.Contains(mida));

            if (mida == "seent")
            {
                List<int> seeneValikud = new List<int>() { 1, 2, 3 };
                int seeneArv = 0;
                do
                {

                    Console.WriteLine("Palun vali seen, mille kohta tahad infot, valikus on " + seeneNimed.Count + "tükki");
                    for (int i = 0; i < seeneNimed.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + seeneNimed.ElementAt(i));
                    }
                    seeneArv = int.Parse(Console.ReadLine());
                } while (!seeneValikud.Contains(seeneArv));

                Console.WriteLine(seeneInfod.ElementAt(seeneArv));


            }
            else if(mida == "marja")
            {


                List<int> marjaValikud = new List<int>() { 1, 2, 3 };
                int marjaArv = 0;
                do
                {

                    Console.WriteLine("Palun vali marja, mille kohta tahad infot, valikus on " + marjaNimed.Count + "tükki");
                    for (int i = 0; i < marjaNimed.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + marjaNimed.ElementAt(i));
                    }
                    marjaArv = int.Parse(Console.ReadLine());
                } while (!marjaValikud.Contains(marjaArv));

                Console.WriteLine(marjaInfod.ElementAt(marjaArv));
            }
            else
            {


                List<int> puuValikud = new List<int>() { 1, 2, 3 };
                int puuArv = 0;
                do
                {

                    Console.WriteLine("Palun vali puu, mille kohta tahad infot, valikus on " + puuNimed.Count + "tükki");
                    for (int i = 0; i < puuNimed.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + puuNimed.ElementAt(i));
                    }
                    puuArv = int.Parse(Console.ReadLine());
                } while (!puuValikud.Contains(puuArv));

                Console.WriteLine(puuInfod.ElementAt(puuArv-1));





            }









                // #n4. "Stonksid"
                // kirjuta programm mis töötab tsüklis ja omab tehtavat koodi mis:
                // küsib kasutajalt temapoolse investeeritava summa
                // küsib kolme firma kohta millesse ta investeerida soovib (Tesla, TransferWise või Macro$lop)
                // valitud firma kohta otsustab programm kordaja.
                // kui selleks on Tesla, siis on kordaja fikseeritud -1.15
                // kui selleks on TransferWise, siis on kordajaks valemi tuleumus kus juhuarvu abil otsustatakse arv vahemikus 1 ja 100, juhuarv jagatakse 1000ga ja sinna liidetakse 1 juurde
                // kui selleks on Macro$lop, siis kasutatakse sama valemit TransferWise puhul, aga arv ise on alati negatiivne.
                // programm küsib ka kasutajalt kui pikaks ajaks (mitu päeva) investeering turul olla lasta
                // tsükkel kirjutab välja iga päeva kohta firmanime, hetkekordaja, kasutajaportfelliväärtuse
                // kui kasutaja portfell pole jõudnud alla nulli, siis kasutaja saab valida kas investeerida uuesti või mitte
                // kui aga portfell on nullis, öeldakse kasutajale et on pankrotis
                // kuvatakse kasutajale tema portfelli lõppväärtus.
            
        }
    }
}
