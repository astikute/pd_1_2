using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums_7
            Console.Write("Ievadiet 1. simbolu virkni: ");
            string vir1 = Console.ReadLine();
            Console.Write("Ievadiet 2. simbolu virkni: ");
            string vir2 = Console.ReadLine();
            Funkcija_virkne(vir1, vir2);

            //Uzdevums_8
            Console.Write("Ievadiet 1. skaitli: ");
            double sk1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ievadiet 2. skaitli: ");
            double sk2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Darbiba: 1. Summa 2. Starpiba 3. Reizinajums 4. Dalijums");
            int darbiba = Convert.ToInt32(Console.ReadLine());
            double rezultats;

            switch (darbiba)
            {
                case 1:
                    rezultats = sk1 + sk2;
                    Console.WriteLine("Summa: " + rezultats);
                    break;
                case 2:
                    rezultats = sk1 - sk2;
                    Console.WriteLine("Starpiba: " + rezultats);
                    break;
                case 3:
                    rezultats = sk1 * sk2;
                    Console.WriteLine("Reizinajums: " + rezultats);
                    break;
                case 4:
                    if (sk1 == 0 || sk2 == 0)
                    {
                        Console.WriteLine("Nav iespejams veikt darbibu!");
                    }
                    else
                    {
                        rezultats = sk1 / sk2;
                        Console.WriteLine("Dalijums: " + rezultats);
                    }
                    break;
                default:
                    Console.WriteLine("Kluda!");
                    break;
            }

            //Uzdevums_9
            Console.Write("Ievadiet GPA: ");
            double GPA = Convert.ToDouble(Console.ReadLine());
            switch (GPA)
            {
                case 4.5:
                    Console.WriteLine("Letter grade: A+");
                    break;
                case 4:
                    Console.WriteLine("Letter grade: A");
                    break;
                case 3.5:
                    Console.WriteLine("Letter grade: B+");
                    break;
                case 3:
                    Console.WriteLine("Letter grade: B");
                    break;
                case 2.5:
                    Console.WriteLine("Letter grade: C+");
                    break;
                case 2:
                    Console.WriteLine("Letter grade: C");
                    break;
                case 1:
                    Console.WriteLine("Letter grade: D");
                    break;
                case 0:
                    Console.WriteLine("Letter grade: F");
                    break;
                default:
                    Console.WriteLine("Kluda!");
                    break;
            }

            //Uzdevums_10
            Console.Write("Ievada skaitli kapinasanai: ");
            double sk_kap = Convert.ToDouble(Console.ReadLine());
            double sk_rez = Funkcija(sk_kap);
            Console.WriteLine("Rezultats: " + sk_rez);

            //Uzdevums_11
            Console.WriteLine("Ievadiet 2 skaitlus:");
            double skaitlis1 = Convert.ToDouble(Console.ReadLine());
            double skaitlis2 = Convert.ToDouble(Console.ReadLine());
            Funkcija_1(skaitlis1, skaitlis2);

            //Uzdevums_12
            double degviela = (13.9*150/100)*1.25;
            Console.WriteLine("Degvielai izteres " + degviela + " eiro.");
            Console.Read();
        }

        //Uzdevums_7_funkcija
        static void Funkcija_virkne (string virkne1, string virkne2)
        {
            Console.WriteLine("Jus ievadijat: " + virkne1 + " " + virkne2);
        }

        //Uzdevums_10_funkcija
        static double Funkcija(double a)
        {
            return Math.Pow(a, 2);
        }

        //Uzdevums_11_funkcija
        static void Funkcija_1(double a, double b)
        {
            if (a > b)
            {
                Console.WriteLine("Lielākais ir " + a);
            }
            else if (b > a)
            {
                Console.WriteLine("Lielākais ir " + b);
            }
            else
            {
                Console.WriteLine("Skaitli ir vienadi!");
            }
        }

    }
}
