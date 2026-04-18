using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueSys
{
    public class Banque : Entite

    {
        public void AjouterAgence(Agence agence) { }
        public void SupprimerAgence(Agence agence) { }
        public List<Agence> ListerAgence() { return null; }

        public void AjouterDistributeur(Distributeur d) { }
        public List<Distributeur> ListerDistributeurs() { return null; }
    }
}
