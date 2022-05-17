using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_4
{
    class Seance
    {
        private Film leFilm;
        private String jour;
        private Horaire heureDebut;
        private int nbPlacesAchetees;
        public static int nbPlacesTotales = 80;
        public static double pleinTarif = 8;
        public static double demiTarif = 5;

        public Film getLeFilm()
        {   return this.leFilm;
        }

        public void setLeFilm(Film leFilm)
        {   this.leFilm = leFilm;
        }

        public int getNbPlacesAchetees()
        {   return this.nbPlacesAchetees;
        }

        public void setNbPlacesAchetees(int nbPlacesAchetees)
        {   this.nbPlacesAchetees = nbPlacesAchetees;
        }

        public Seance(String jour, Horaire heure, Film film)
        {
            this.jour = jour;
            this.heureDebut = heure;
            this.leFilm = film;
            this.nbPlacesAchetees = 0;
        }

        public String toString()
        {
            return "\nFilm:" + this.leFilm.toString() + "\nSeance : " + this.jour + " " +
                  this.heureDebut.toString() + "\nNb places dispos :"
                + this.calculNbPlacesRestantes();
        }

        public int calculNbPlacesRestantes()
        {   return Seance.nbPlacesTotales - this.nbPlacesAchetees;
        }

        public static double calculMontant(int nbDemiTarif, int nbPleinTarif)
        {
            double montant = nbDemiTarif * Seance.demiTarif + nbPleinTarif * Seance.pleinTarif;
            return montant;
        }

        public bool assezDePlace(int nb)
        {
            if (nb <= this.calculNbPlacesRestantes())
                return true;
            else
                return false;
        }

        public void reserver(int nb)
        {   this.nbPlacesAchetees = this.nbPlacesAchetees + nb;
        }

    }
}
