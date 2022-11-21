using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;



namespace EvidencePojisteni2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vytvoří novou instanci třídy Evidence
            Evidence ev = new Evidence();

            char volba = '0';

            // hlavní cyklus programu
            while (volba != '4')
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("Evidence pojištěných");
                Console.WriteLine("------------------------------");
                Console.WriteLine("\nVyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojistěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Ukončit aplikaci");

                volba = Console.ReadKey().KeyChar;

                // reakce na volbu
                switch (volba)
                {
                    case '1':
                        ev.ZjistiInicialy();
                        break;
                    case '2':
                        ev.VypisPojistene();
                        break;
                    case '3':
                        ev.VyhledejPojisteneho();
                        break;
                    case '4':
                        Console.WriteLine("\nLibovolnou klávesou ukončíte program...");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.ReadKey();
            }   
        }
        
    }
}