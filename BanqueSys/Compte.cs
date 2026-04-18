using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BanqueSys
{
    public class Compte
    {
        private string NumeroCompte;
        private double Solde;
        private DateTime DateOuverture;
        private Agence Banque;

        public Compte() { }
        public void Cloturer() { }
        public void Crediter(double montant) { }
        public bool Debiter(double montant) { return false; }
        public bool Transferer(Compte vers, double montant) { return false; }
        public void AjouterCarte(Carte carte) { }
        public void SupprimerCarte(Carte carte) { }
        public double GetSolde() { return 0; }
        public List<Transaction> GenererReleve() { return null; }
    }
}
