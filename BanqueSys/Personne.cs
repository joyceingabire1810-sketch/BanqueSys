using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BanqueSys
{
    public class Personne
    {
        private string Nom;
        private string Prenom;
        private Sexe Sexe; 

        public void Afficher() { }
        public void AjouterCompte(Compte compte, string role) { }
        public void SupprimerCompte(Compte compte) { }
        public List<Compte> ListerComptes() { return null; }
        public List<Carte> ObtenirCartes() { return null; }
    }
}
