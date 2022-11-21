using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni2
{

    /// <summary>
    /// Třida spravující databázi pojíštěných
    /// </summary>
    class DatabazePojistenych
    {

        /// <summary>
        /// kolekce záznamů pojíštěných
        /// </summary>
        private List<Pojisteny> databazePojistenych { get; set; }

        /// <summary>
        /// Vytvoří novou instanci databáze
        /// </summary>
        public DatabazePojistenych()
        {
            databazePojistenych = new List<Pojisteny>();
        }

        /// <summary>
        /// Přidá nového Pojištěného do databáze
        /// </summary>
        /// <param name="jmeno">Jméno pojíštěného</param>
        /// <param name="prijmeni">Přijmení pojíštěného</param>
        /// <param name="telefon">Telefonní číslo pojíštěného</param>
        /// <param name="vek">Věk pojíštěného</param>
        public void PridejPojisteneho(string jmeno, string prijmeni, int telefon, byte vek)
        {
            databazePojistenych.Add(new Pojisteny(jmeno, prijmeni, telefon, vek));
        }

        /// <summary>
        /// Vrátí textovou reprezentaci databáze Pojíštěných
        /// </summary>
        /// <returns>Textová reprezentace databáze Pojíštěných</returns>
        public List<Pojisteny> VypisPojistenych()
        {
            return databazePojistenych;
        }

        /// <summary>
        /// Vyhledání všech záznamů
        /// </summary>
        public void VyhledejPojistene()
        {
            foreach (Pojisteny p in databazePojistenych)
            {
                Console.WriteLine(p);
            }
        }

    }
}
