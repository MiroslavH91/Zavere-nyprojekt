using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni2
{
    class Pojisteny
    {
        /// <summary>
        /// Jméno pojištěného
        /// </summary>
        public string Jmeno { get; set; }

        /// <summary>
        /// Přijmení pojíštěného
        /// </summary>
        public string Prijmeni { get; set; }

        /// <summary>
        /// Telefonní číslo
        /// </summary>
        public int Telefon { get; set; }

        /// <summary>
        /// Věk pojíštěného
        /// </summary>
        public byte Vek { get; set; }

        /// <summary>
        /// Vytvoří novou instanci Pojištěného kde uloží jeho jméno, příjmení, telefonní číslo a věk
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="telefon"></param>
        /// <param name="vek"></param>
        public Pojisteny(string jmeno, string prijmeni, int telefon, byte vek)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Telefon = telefon;
            this.Vek = vek;
        }

        /// <summary>
        /// Vrátí textovou reprezentaci Pojištěného
        /// </summary>
        /// <returns>Textová reprezentace Pojištěného</returns>
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + Telefon + " " + Vek;
        }
    }
}