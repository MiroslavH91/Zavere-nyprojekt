using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni2
{
    class Evidence
    {

        /// <summary>
        /// Databáze pojíštěných
        /// </summary>
        private DatabazePojistenych databazePojistenych;

        /// <summary>
        /// Vytvoří novou instanci databáze pojíštěných
        /// </summary>
        public Evidence()
        {
            databazePojistenych = new DatabazePojistenych();
        }

        /// <summary>
        /// Vyptá se iniciály Pojíštěného a uloží je do databáze
        /// </summary>
        public void ZjistiInicialy()
        {
            Console.WriteLine("\nZadejte jméno pojištěného:");
            string Jmeno = "";
            while (string.IsNullOrWhiteSpace(Jmeno))
            {
                Jmeno = Console.ReadLine().Trim();
            }

            Console.WriteLine("Zadejte příjmení pojištěného:");
            string Prijmeni = "";
            while (string.IsNullOrEmpty(Prijmeni))
            {
                Prijmeni = Console.ReadLine().Trim();
            }

            Console.WriteLine("Zadejte telefonní číslo pojištěného:");
            int Telefon;
            while (!int.TryParse(Console.ReadLine(), out Telefon))
            {
                Console.WriteLine("Neplatné číslo, zkuste telefonní číslo zadat znovu:");
            }
            Console.WriteLine("Zadejte věk pojištěného:");
            byte Vek;
            {
                while (!byte.TryParse(Console.ReadLine(), out Vek))
                    Console.WriteLine("Neplatné číslo, zkuste svůj věk zadat znovu:");
            }


            ///Potvrzení přidání nového pojištěného
            databazePojistenych.PridejPojisteneho(Jmeno, Prijmeni, Telefon, Vek);
            Console.WriteLine("\nData byla přidána, pokračujte libovolnou klávesou...");
        }

        /// <summary>
        /// Vyptá se na jméno a příjmení pojíštěného a vyhledá ho
        /// </summary>
        public void VyhledejPojisteneho()
        {

            Console.WriteLine("\nZadejte jméno Pojístěného:");
            string HledaneJmeno = "";
            while (string.IsNullOrEmpty(HledaneJmeno))
            {
                HledaneJmeno = Console.ReadLine().Trim().ToLower();
            }

            Console.WriteLine("Zadejte příjmení pojíštěného:");
            string HledanePrijmeni = "";
            while (string.IsNullOrEmpty(HledanePrijmeni))
            {
                HledanePrijmeni = Console.ReadLine().Trim().ToLower();
            }

            Pojisteny nalezene = databazePojistenych.VypisPojistenych().Find(delegate (Pojisteny po)
            {
                return po.Jmeno.ToLower() == HledaneJmeno && po.Prijmeni.ToLower() == HledanePrijmeni;
            }
                );
            if (nalezene != null)
            {
                Console.WriteLine("\n" + nalezene);
            }
            else
            {
                Console.WriteLine("\nPojištěný neexistuje.");
            }

            Console.WriteLine("\nPokračujte stisknutím libovolné klávesy...");
        }

        /// <summary>
        /// Iniciace výpisu všech pojíštěných
        /// </summary>
        public void VypisPojistene()
        {
            Console.WriteLine("\n");
            databazePojistenych.VyhledejPojistene();
            Console.WriteLine("\nPokračujte stisknutím libovolné klávesy...");
        }

    }
}