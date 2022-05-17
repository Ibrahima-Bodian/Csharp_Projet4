using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_4
{
    class Film
    {
        private String titreF;
        private int dureeF;

        public int getDureeF()
        { return this.dureeF; }

        public void setDureeF(int dureeF)
        { this.dureeF = dureeF; }

        public String getTitreF()
        { return this.titreF; }

        public void setTitreF(String titreF)
        { this.titreF = titreF; }

        public Film() { }

        public Film(int dureef, String titref)
        {
            this.dureeF = dureef;
            this.titreF = titref;
        }

        public String toString()
        { return "Titre: " + this.titreF + " Duree :" + this.dureeF; }

    }
}
