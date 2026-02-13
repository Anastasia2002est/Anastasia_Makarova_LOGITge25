namespace General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// #n1. "Tervitus"
            //// kirjuta programm mis,
            //// - küsib tsükliga kasutajalt tema eesnime
            //string eesNimi = string.Empty;
            //while (eesNimi == string.Empty)
            //{
            //    Console.WriteLine("Palun sisesta oma nimi siia: ");
            //    eesNimi = Console.ReadLine();
            //}
            //// - - küsitakse uuesti tühja sisendi korral
            //// - küsib kasutajalt tema keskmist nime
            //string keskmineNimi = string.Empty;
            //while (keskmineNimi == string.Empty)
            //{
            //    Console.WriteLine("Palun sisesta keskmine nimi siia: ");
            //    keskmineNimi = Console.ReadLine();
            //}
            //// - - küsitakse uuesti tühja sisendi korral
            //// - küsib kasutajalt tema perekonnanime
            //string perekonnaNimi = "";
            //while (!(perekonnaNimi != string.Empty))
            //{
            //    Console.WriteLine("Palun sisesta ka oma perekonnanimi siia: ");
            //    perekonnaNimi = Console.ReadLine();
            //}
            //// - - küsitakse uuesti tühja sisendi korral
            //// - tema vanust
            //int minuVanus = 0;
            //while (minuVanus < 1)
            //{ 
            //    Console.WriteLine("Palun sisesta ka oma vanus siia: ");
            //    minuVanus = int.Parse(Console.ReadLine());
            //}
            //// - - küsitakse uuesti tühja sisendi korral
            //// - ning väljastab talle tervituslause, kasutades kõiki muutujaid
            //Console.WriteLine($"Tere päevast {eesNimi} {perekonnaNimi}! Või kutsun sind {keskmineNimi}? Oled tublisti kasvanud, oled juba {minuVanus}-aastane");


            // #n2. "Minu lemmiksnäkk"
            // kirjuta programm mis
            // küsib kasutajalt mis on ta lemmiksnäkk
            // programm kontrollib tsükliga kas järjendis on snäkk olemas
            // kui tsüklis leitakse snäkk, kuva tekst koos kasutajasisendiga, "jaa :D tean seda, {snäkk} on hea"
            // kui tsükkel lõppeb ilma snäkki leidmata, kuva tekst "ei tunne kahjuks {snäkk}i :C"

            //// nimekiri snäkkidest
            //List<string> snäkid = new List<string>() {"limonaad","kõrsikud","ŠnikurŠ","krõpsud","popcorn" };
            //// kasutaja sisestuse jaoks muutuja
            //string kasutajaleMeeldib = string.Empty;
            //// kas snäkk on olemas või mitte, vaikeväärtusena ei ole
            //bool isPresent = false;
            //// tsükkel mis käib niikaua kuni leitakse kasutajale meeldiv snäkk mida programm teab
            //while (isPresent != true) 
            //{
            //    // küsime kasutajalt infot
            //    Console.WriteLine("Sisesta oma lemmiksnäkk: ");
            //    kasutajaleMeeldib = Console.ReadLine();

            //    //kontrollime seda infot
            //    foreach (var snäkk in snäkid)
            //    {
            //        // kui leitakse vaste
            //        if (snäkk == kasutajaleMeeldib)
            //        {
            //            // seatakse muutujale väärtus true
            //            isPresent = true;
            //        }
            //    }
            //    // kuvame kasutajale sõnumi olenevalt infokontrolli tulemuse tagajärjel
            //    if (isPresent == true) // kui leitakse, kuvatakse sõnum a
            //    {
            //        Console.WriteLine($"jaa :D tean seda, {kasutajaleMeeldib} on hea");
            //    }
            //    else // muidu kuvatakse sõnum b
            //    {
            //        Console.WriteLine($"ei tunne kahjuks {kasutajaleMeeldib}i :C");
            //    }
            //}

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

            bool anuddaJuan = true; // hoiame meeles kas kasutaja tahab veel infot
            string mida = string.Empty; // mida kasutaja täpselt tahab
            List<string> valikud = new List<string>() { "seent", "marja", "puud" }; // loend võimalike valikutega
            List<string> seeneNimed = new List<string> { "kukeseen", "puravik", "sitaseen" }; // seenevalikute loend nimedega
            List<string> seeneInfod = new List<string>
            {
                "Kukeseen on kollane ja näeb välja nagu keegi oleks pasuna maha \nmatnud ning siis mootorattaga üle sõitnud.",
                "Puravik on pealt pruun ja jalg on hele. Siuke ilus punsu.",
                "Sitaseen on pruun, keerlev ja tõenäoliselt lähima koera poolt tehtud kingitus."
            }; // seente infode loend
            List<string> marjaNimed = new List<string> { "astelpaju", "muulukas", "maasikas" }; // marjavalikute loend nimedega
            List<string> marjaInfod = new List<string>
            {
                "Astelpaju on kollane, maitseb nagu apelsin ja selle seeme on alfa-suurusega",
                "Kes seda teab milline muulukas välja näeb...",
                "Maasikas on maailma parim mari, kui sa leiad selle metsast, mitte poest."
            };// marjade infode loend
            List<string> puudeNimed = new List<string> { "Tamm", "Saar", "Banaanipalm" }; // puudevalikute loend nimedega
            List<string> puudeInfod = new List<string>
            {
                "Tamm on suur ja tugev ning võib elada mitmesaja aastaseks, lehed on sinkavonkalised.",
                "Saar on ka suur ja tugev, kuid erinevalt tammest ei ole mürgine.",
                "Banaanipalm on rohuline, mingi tohman pani selle puude hulka."
            };// puude infode loend

            while (anuddaJuan == true) // tsükkel käib niikaua kuni kasutaja tahab infot veel saada
            {
                do // kusime kasutajalt selle tsükliga mida ta tahab
                {
                    Console.WriteLine("Kas sa otsid seent, marja või puud?");
                    mida = Console.ReadLine(); // omistame muutujasse väärtuse
                }
                //while (mida != "seent" || mida != "marja");
                //while (!new List<string>() { "seent", "marja"}.Contains(mida));
                while (!valikud.Contains(mida)); //ning kontrollime kas sisestatud väärtus on üks valikutest

                if (mida == "seent") // kui on valitud seent
                {
                    List<int> seeneValikud = new List<int>() { 1, 2, 3 }; //tekitame võimalike sisestuste arvloendi
                    int seeneArv = 0; // hetkel on valik väljaspool võimalikke arvude vahemikku
                    do // küsime kasutajalt millist seent võimalikest ta tahab
                    {
                        Console.WriteLine("Palun vali seen, mille kohta tahad infot, valikus on " + seeneNimed.Count + " tükki");
                        for (int i = 0; i < seeneNimed.Count; i++) //kuvame valikud arvudega
                        {
                            Console.WriteLine((i + 1) + ". " + seeneNimed.ElementAt(i));
                        }
                        seeneArv = int.Parse(Console.ReadLine()); //ja ootame kuni kasutaja sisestab arvu
                    } while (!seeneValikud.Contains(seeneArv)); // küsime niikaua kuni sisestatud on üks valikutest

                    Console.WriteLine(seeneInfod.ElementAt(seeneArv - 1)); // kui tsükkel saavutab tahetud tulemuse kuvame valiku
                }
                else if (mida == "marja") // kui on valitud marja siis -||-
                {
                    List<int> marjaValikud = new List<int>() { 1, 2, 3 };
                    int marjaArv = 0;
                    do
                    {
                        Console.WriteLine("Palun vali mari, mille kohta tahad infot, valikus on " + marjaNimed.Count + " tükki");
                        for (int i = 0; i < marjaNimed.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + marjaNimed.ElementAt(i));
                        }
                        marjaArv = int.Parse(Console.ReadLine());
                    } while (!marjaValikud.Contains(marjaArv));

                    Console.WriteLine(marjaInfod.ElementAt(marjaArv - 1));
                }
                else // kui on valitud midagi muud, antud juhul saab ainult puud olla, siis ka  -||-
                {
                    List<int> puudeValikud = new List<int>() { 1, 2, 3 };
                    int puudeArv = 0;
                    do
                    {
                        Console.WriteLine("Palun vali mari, mille kohta tahad infot, valikus on " + puudeNimed.Count + " tükki");
                        for (int i = 0; i < puudeNimed.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + puudeNimed.ElementAt(i));
                        }
                        puudeArv = int.Parse(Console.ReadLine());
                    } while (!puudeValikud.Contains(puudeArv));

                    Console.WriteLine(puudeInfod.ElementAt(puudeArv - 1));
                }
                string kasutajaOtsus = ""; // teeme muutuja kasutaja otsuse jaoks programmi kasutamise kohta
                do //küsime talt kas ta tahab infot veel
                {
                    Console.WriteLine("Kas tahad veel infot? jah/ei"); 
                    kasutajaOtsus = Console.ReadLine(); //ootame temalt vastuse
                } while ((kasutajaOtsus != "jah" && kasutajaOtsus != "ei")); //ning kui ta ei ole jah või ei, küsime uuesti
                if (kasutajaOtsus == "jah") // kui vastus on jah
                {
                    anuddaJuan = true; //seame muutuja mis hoiab meeles kas kasutaja tahab veel infot väärtuseks true
                }
                else
                {
                    anuddaJuan = false; //kõige muu puhul false
                }
            }
            Console.WriteLine("Head aega!"); //kui põhitsükkel katkeb, ütleme headaega
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
