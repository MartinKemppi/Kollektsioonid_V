using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alamprogrammid
{
    internal class Alamprogramm
    {
        public static double Keskmine(int k)
        {
            int[] numbers = new int[k];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"Sisesta number {i + 1}");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double arth = (double)sum / numbers.Length;

            return arth;
        }

        public static string Kassi_kalkulaator(int arv1, int arv2, char tehe)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            double j = Convert.ToDouble(table.Compute(arv1.ToString() + tehe.ToString() + arv2.ToString(), String.Empty));

            j = Math.Round(j, 0);
            string vastus = "";
            string nur = "nurr ";
            for (int i = 0; i < Math.Abs(Convert.ToInt32(j)); i++)
            {
                vastus = vastus + nur;
            }
            return vastus;

        }

        public static void Stars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }

        public static void NStars(int k)
        {
            int[] stars = new int[k];
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("{0} arv", i + 1);
                stars[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int num in stars)
            {
                Stars(num);
                Console.WriteLine();
            }
        }

        public static void Näita(string filename)
        {
            File.ReadAllLines(filename);
            string filePath = @"C:\Users\opilane\source\repos\MartinKemppi_TARpv22\Eesti_maakonnad_ja_pealinnad-master\Eesti.txt";
            Dictionary<string, string> maakonnad = LoeDictFailist(filePath);
            Console.WriteLine();
            foreach (KeyValuePair<string, string> maakond in maakonnad)
            {
                Console.WriteLine($"  {maakond.Key} : {maakond.Value}");
            }
            Console.WriteLine();
        }

        public static Dictionary<string, string> LoeDictFailist(string filename)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new char[] { ':' }, 2);
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();
                        dictionary[key] = value;
                    }
                    else
                    {
                        Console.WriteLine($"Viga: Vale vorming real '{line}'.");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Viga: fail ei leitud '{filename}'.");
            }

            return dictionary;
        }
        public static void LisaMaakondDict(Dictionary<string, string> maakonnad, string input,string filename)
        {
            try
            {
                File.ReadAllLines(filename);               
                StreamWriter text = new StreamWriter(@"C:\Users\opilane\source\repos\MartinKemppi_TARpv22\Eesti_maakonnad_ja_pealinnad-master\Eesti.txt", true);
                Console.Write("Sisestage maakonna nimi: ");
                string maakond = Console.ReadLine().Trim();
                Console.Write("Sisestage pealinna nimi: ");
                string pealinn = Console.ReadLine().Trim();
                maakonnad[maakond] = pealinn;

                Console.WriteLine($"Lisatud '{maakond}' pealinnaga '{pealinn}' sõnastiku.");
                string lause = maakond + ":" + pealinn;
                text.WriteLine(lause);
                text.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga");
                throw;
            }
        }

        public static void Test(string filename)
        {
            string filePath = @"C:\Users\opilane\source\repos\MartinKemppi_TARpv22\Eesti_maakonnad_ja_pealinnad-master\Eesti.txt";
            Dictionary<string, string> maakonnad = LoeDictFailist(filePath);
            Random random = new Random();
            List<string> countyList = new List<string>(maakonnad.Keys);
            int tulemus = 0;

            Console.WriteLine("Sisestage iga maakonna pealinn.");
            for (int i = 0; i < 10; i++)
            {
                string county = countyList[random.Next(countyList.Count)];
                Console.Write($"{county}: ");
                string answer = Console.ReadLine().Trim();
                if (answer == maakonnad[county])
                {
                    Console.WriteLine("Õige!");
                    tulemus++;
                }
                else
                {
                    Console.WriteLine($"Vale. Õige vastus on {maakonnad[county]}.");
                }
            }
            Console.WriteLine($"Said {tulemus} 10-st ({tulemus * 10}%).");
        }

        public static void Otsi(string filename)
        {
            File.ReadAllLines(filename);
            string filePath = @"C:\Users\opilane\source\repos\MartinKemppi_TARpv22\Eesti_maakonnad_ja_pealinnad-master\Eesti.txt";
            Dictionary<string, string> maakonnad = LoeDictFailist(filePath);
            Console.Write("Kas soovite otsida maakonna või pealinna järgi? (sisestage 'maakond' või 'pealinn'): ");
            string Otsime = Console.ReadLine().Trim().ToLower();

            if (Otsime == "maakond")
            {
                Console.Write("Sisestage maakonna nimi: ");
                string maakond = Console.ReadLine().Trim();

                if (maakonnad.ContainsKey(maakond))
                {
                    Console.WriteLine($"{maakond} pealinn on {maakonnad[maakond]}.");
                }
                else
                {
                    Console.WriteLine($"Maakonna '{maakond}' pealinna ei leitud.");
                }
            }
            else if (Otsime == "pealinn")
            {
                Console.Write("Sisestage pealinna nimi: ");
                string pealinn = Console.ReadLine().Trim();

                if (maakonnad.ContainsValue(pealinn))
                {
                    string maakond = maakonnad.FirstOrDefault(x => x.Value == pealinn).Key;
                    Console.WriteLine($"{pealinn} on maakonna {maakond} pealinn.");
                }
                else
                {
                    Console.WriteLine($"Pealinna '{pealinn}' ei leitud.");
                }
            }
            else
            {
                Console.WriteLine($"Vale sisend '{Otsime}'. Palun sisestage 'maakond' või 'pealinn'.");
            }
        }
    }
}