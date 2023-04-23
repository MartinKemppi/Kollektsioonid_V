using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alamprogrammid
{
    internal class Mein
    {
        public static void Main(string[] args)
        {
            /*
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Esimene");
            //arrayList.Add("Teine");
            //arrayList.Add("Kolmas");
            //if (arrayList.Contains("Teine"))
            //{
            //    Console.WriteLine("Sõna Teine on olemas");
            //    Console.WriteLine("Teine asub kohal " + arrayList.IndexOf("Teine"));
            //}
            //else
            //{
            //    Console.WriteLine("Otsitav sõna puudub");
            //}
            //Console.WriteLine("Kokku järjendis on "+arrayList.Count+" elemente");
            //arrayList.Insert(3, "Neljas");
            //arrayList.Insert(4, "Viies");
            //arrayList.Sort();
            //foreach (string item in arrayList)
            //{
            //    Console.Write(item + ", ");
            //}
            //arrayList.RemoveAt(0);
            //arrayList.Remove("Viies");
            //arrayList.Clear();

            //List<Inimene> list = new List<Inimene>();
            //Inimene inimene = new Inimene();
            //inimene.Nimi = "Mati";
            //inimene.Vanus = 65;
            //list.Add(inimene);
            //list.Add(new Inimene() { Nimi = "Kati" });

            //foreach (Inimene item in list)
            //{
            //    Console.WriteLine(item.Nimi);
            //}

            //Dictionary<int, string> dic = new Dictionary<int, string>(5);
            //dic.Add(1, "Üks");
            //dic.Add(2, "Kaks");
            //dic[3] = "Kolm";
            //dic.Add(4, "Neli");
            //dic.Add(5, "Viis");
            //foreach (KeyValuePair<int,string> keyValue in dic)
            //{
            //    Console.WriteLine(keyValue.Key+" - "+keyValue.Value);
            //}

            //Dictionary<int, Inimene> õpilased = new Dictionary<int, Inimene>(3);
            //Inimene inimene = new Inimene();
            //inimene.Nimi = "Mati";
            //inimene.Vanus = 65;
            //Inimene inimene2 = new Inimene();
            //inimene2.Nimi = "Kati";
            //inimene2.Vanus = 35;
            //õpilased.Add(1, inimene);
            //õpilased.Add(2, inimene2);
            //õpilased.Add(3, new Inimene() {Nimi = "Marina", Vanus = 100});
            //foreach (Inimene item in õpilased.Values)
            //{
            //    Console.WriteLine(item.Nimi);
            //}

            //foreach (KeyValuePair<int, Inimene> item in õpilased)
            //{
            //    Console.WriteLine(item.Key +": "+item.Value.Nimi);
            //}

            //try
            //{
            //    StreamWriter text = new StreamWriter(@"..\..\..\TextFile.txt",true);
            //    string lause = "Lisan failisse lause\n";
            //    text.WriteLine(lause);
            //    text.Close();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga");
            //    throw;
            //}

            //try
            //{
            //    StreamReader text = new StreamReader(@"..\..\..\TextFile.txt", true);
            //    string laused = text.ReadToEnd();
            //    text.Close();
            //    Console.WriteLine("Failis on jägrmine informatsion: \n");
            //    Console.WriteLine(laused);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga");
            //    throw;
            //}

            //List<string> list_failist = new List<string>();
            //try
            //{
            //    foreach (string rida in File.ReadAllLines(@"..\..\..\TextFile.txt"))
            //    {
            //        list_failist.Add(rida);
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Viga failiga");
            //    throw;
            //}
            //foreach (var rida in list_failist)
            //{
            //    Console.WriteLine(rida);
            //}


            //ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            //do
            //{
            //    Console.WriteLine("Varjuta Backspace");
            //    nupp=Console.ReadKey();
            //} while (nupp.Key !=ConsoleKey.Backspace);

            //double aritm = Alamprogramm.Keskmine(2);
            //Console.WriteLine(aritm);

            //string kassid = Alamprogramm.Kassi_kalkulaator(25,35,'+');
            //Console.WriteLine(kassid);

            //Alamprogramm.Stars(20);

            //Alamprogramm.NStars(5);
            */
            //1
            /*
            Random rnd = new Random();
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            for (int i = 0; i < rnd.Next(3, 5); i++)
            {
                int a = rnd.Next(1, 10);
                list.Add(a);
            }
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            list.Insert(0, list[list.Count - 1]);
            list.Insert(list.Count, list[1]);
            Console.WriteLine();
            for (int i = 1; i < list.Count - 1; i++)
            {
                list1.Insert(i - 1, list[i - 1] + list[i + 1]);
            }
            foreach (int i in list1)
            {
                Console.Write(i + " ");
            }
            */
            //2
            /*
            var random = new Random();
            List<int> numbers = Enumerable.Range(1, 20)
                .Select(i => random.Next(-100, 100))
                .ToList();

            numbers.Sort((a, b) => {
                if (Math.Sign(a) == Math.Sign(b))
                {
                    return a.CompareTo(b);
                }

                else if (a >= 0)
                {
                    return -1;
                }

                else
                {
                    return 1;
                }
            });            
            Console.WriteLine(string.Join(" ", numbers));
            */
            //3
            /*
            List<string> tooded = new List<string> { "õun", "banaan", "porgand", "jogurt" };
            List<int> kalorid = new List<int> { 95, 105, 25, 150 };

            Console.WriteLine("Palun sisestage oma kaal kilogrammides:");
            double kaal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Palun sisestage oma pikkus sentimeetrites:");
            double kõrgus = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Palun sisestage oma vanus aastates:");
            int vanus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Palun sisestage oma sugu (m/n):");
            string sugu = Console.ReadLine().ToLower();

            double bmr;
            if (sugu == "m")
            {
                bmr = 66 + (13.7 * kaal) + (5 * kõrgus) - (6.8 * vanus);
            }
            else if (sugu == "n")
            {
                bmr = 655 + (9.6 * kaal) + (1.8 * kõrgus) - (4.7 * vanus);
            }
            else
            {
                Console.WriteLine("Vale sisestatud andme.");
                return;
            }

            Console.WriteLine("Valige oma aktiivsuse tase:");
            Console.WriteLine("1 - Istuv");
            Console.WriteLine("2 - Kerge tegevus");
            Console.WriteLine("3 - Mõõdukalt aktiivne");
            Console.WriteLine("4 - Kõrge aktiivsus");
            Console.WriteLine("5 - Väga kõrge aktiivsus");
            int tegevustase = Convert.ToInt32(Console.ReadLine());

            double kalorite_tarbimine;
            switch (tegevustase)
            {
                case 1:
                    kalorite_tarbimine = bmr * 1.2;
                    break;
                case 2:
                    kalorite_tarbimine = bmr * 1.375;
                    break;
                case 3:
                    kalorite_tarbimine = bmr * 1.55;
                    break;
                case 4:
                    kalorite_tarbimine = bmr * 1.725;
                    break;
                case 5:
                    kalorite_tarbimine = bmr * 1.9;
                    break;
                default:
                    Console.WriteLine("Vale tegevustaseme sisend.");
                    return;
            }

            Console.WriteLine("Teie päevane kalorite tarbimine peaks olema {0} kaloreid.", kalorite_tarbimine);
            Console.WriteLine("Siin on nimekiri toitudest ja sellest, kui palju võite päevas süüa:");

            for (int i = 0; i < tooded.Count; i++)
            {
                int max_t_p_p = (int)Math.Floor(kalorite_tarbimine / kalorid[i]);
                Console.WriteLine("{0}: {1} - kuni {2} portsjonit päevas", i + 1, tooded[i], max_t_p_p);
            }
            */
            //4
            /*
            string filePath = @"C:\Users\opilane\source\repos\MartinKemppi_TARpv22\Eesti_maakonnad_ja_pealinnad-master\Eesti.txt";
            Dictionary<string, string> maakonnad = Alamprogramm.LoeDictFailist(filePath);

            Console.WriteLine("Sisesta 'help' saadaolevate käskude kuvamiseks.");

                while (true)
                {
                    Console.Write("Sisestage käsk: ");
                    string input = Console.ReadLine().Trim().ToLower();

                if (input == "help")
                {
                    Console.WriteLine("Saadaolevad käsud:\n  help - kuvab see abiteade" +
                    "\n  list - näitab maakonnad ja nende pealinnad" +
                    "\n  otsi - otsib maakonna või pealinna" +
                    "\n  test - alustada teadmiste kontrolli maakonna ja pealinna nimede kohta" +
                    "\n  lisa - lisab maakonna ja tema pealinna sõnastiku ");
                }
                else if (input == "list")
                {
                    Alamprogramm.Näita(filePath);                   
                }

                else if (input == "test")
                {
                    Alamprogramm.Test(filePath);                  
                }
                else if (input == "otsi")
                {
                    Alamprogramm.Otsi(filePath);
                    
                }
                else if (input == "lisa")
                {
                    Alamprogramm.LisaMaakondDict(maakonnad, input, filePath);
                }
                                    
                else
                {
                    Console.WriteLine("Kirjuta ainult need sõnad mis on ettevalmistatud");
                }                 
                    
            }
            */

        }        
    }
}  