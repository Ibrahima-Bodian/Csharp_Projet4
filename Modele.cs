using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4
{
    [Serializable()]
    class Modele
    {
        private string nomModele;
        private float prixModele;
        private float depreciation;

        public Modele(string nom, float prix)
        {
            this.nomModele = nom;
            this.prixModele = prix;
        }

        public Modele(string nom, float prix, float depreciation)       // question 6
        {
            this.nomModele = nom;
            this.prixModele = prix;
            this.depreciation = depreciation;
        }

        public float getDepreciation()                                  // question 6
        {
            return this.depreciation;
        }

        public void setPrix(float prix)
        {
            this.prixModele = prix;
        }

        public float getPrix()
        {
            return this.prixModele;
        }

        public string getNomModele()
        {
            return this.nomModele;
        }

    }
}
