using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueSys
{
    public class Carte
    {
        private string NumeroCarte;
        private DateTime DateEmission;
        private DateTime DateExpiration;
        private string CVC;
        private bool Bloquee;
        private Personne Personne;

        public void BloqueCarte() { }
        public bool Payer(double montant) { return false; }
    }
}
