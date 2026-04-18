using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueSys
{
    public class Entite
    {
        private string Nom { get; set; }
        private string Adresse { get; set; }
        private string Telephone { get; set; }
        private string Email { get; set; }

        public void Afficher() { }
        public void ModifierCoordonnees(string adresse, string telephone, string email) { }
    }
}
