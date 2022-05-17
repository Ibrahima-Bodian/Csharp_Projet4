using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_4
{
    [Serializable()]
    class Voiture
    {
        private string immatriculation;
        private int annee;
        private int kilométrage;
        private Modele leModele;
        private string motorisation;

        public Voiture()
        {

        }

        public Voiture(string immat, int annee, int kms, Modele mod)
        {
            this.immatriculation = immat;
            this.annee = annee;
            this.kilométrage = kms;
            this.leModele = mod;
        }

        public Voiture(string immat, int annee, int kms, Modele mod, string motorisation)
        {
            this.immatriculation = immat;
            this.annee = annee;
            this.kilométrage = kms;
            this.leModele = mod;
            this.motorisation = motorisation;
        }

        public float valeur()
        {
            float val;
            int kms, age;
            
            if (this.motorisation == "d")
                kms = 25000;
            else
                kms = 15000;
            age = DateTime.Today.Year - this.annee;
            val = this.calculPrixDeBase() + (age * kms - this.getKms()) * 0.1f; 
            return val;
        }

        public void setKms(int kms)
        {
            this.kilométrage = kms;
        }

        public string getImmatriculation()
        {
            return this.immatriculation;
        }

        public int getAnnee()
        {
            return this.annee;
        }

        public int getKms()
        {
            return this.kilométrage;
        }

        public float calculPrixDeBase()
        {
            float res;
            res = this.leModele.getPrix();
            //res = res - (DateTime.Today.Year - this.annee) * 1000;                                // question 3
            res = res - (DateTime.Today.Year - this.annee) * this.leModele.getDepreciation();       // question 6
            return res;
        }

        public void afficheInfos()
        {
            Console.Out.WriteLine("Véhicule : " + this.immatriculation);
            Console.Out.WriteLine("Année : " + this.annee);
            Console.Out.WriteLine("Kilométrage : " + this.kilométrage);
            Console.Out.WriteLine("Nom du modèle : " + this.leModele.getNomModele());
            Console.Out.WriteLine("Prix de base : " + this.calculPrixDeBase());
            Console.Out.WriteLine("Valeur : " + this.valeur());
        }

        public Modele getLeModele()
        {
            return this.leModele;
        }
    }
}
