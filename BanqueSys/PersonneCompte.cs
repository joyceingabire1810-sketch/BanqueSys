using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueSys
{
    public class PersonneCompte
    {
        private string Role;
        private double LimiteJournalier;

        public void ModifierRole(string role) { }
        public void ModifierLimite(double limite) { }
        public bool VerifierPlafond(double montant) { return false; }
    }
}
