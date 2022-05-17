using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Projet_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Film leFilm = new Film(120, "Narnia");
            Horaire heure = new Horaire(21, 30);
            Seance laSeance = new Seance("Lundi", heure, leFilm);
            char autreResa = 'o';
            int nbPlaceRestantes;
            Console.Out.WriteLine(laSeance.toString());
            do
            {
                Console.Out.WriteLine("Combien de places ?");
                int nb = Convert.ToInt32(Console.In.ReadLine());
                if (nb <= laSeance.calculNbPlacesRestantes())
                {
                    Console.Out.WriteLine("Combien de demi tarif ?");
                    int nbDemiTarif = Convert.ToInt32(Console.In.ReadLine());
                    int nbPleinTarif = nb - nbDemiTarif;
                    double mt = nbDemiTarif * Seance.demiTarif + nbPleinTarif * Seance.pleinTarif;
                    Console.Out.WriteLine("Montant : " + mt);
                    Console.Out.WriteLine("Confirmez vous (o/n) ?");
                    char confirm = Convert.ToChar(Console.In.ReadLine());
                    if (confirm == 'O' || confirm == 'o')
                    {
                        int newNbPlaceAch = laSeance.getNbPlacesAchetees() + nb;
                        laSeance.setNbPlacesAchetees(newNbPlaceAch);
                    }
                }
                else
                    Console.Out.WriteLine("Plus assez de places !");

                nbPlaceRestantes = laSeance.calculNbPlacesRestantes();
                Console.Out.WriteLine("Places dispos : " + nbPlaceRestantes);
                if (nbPlaceRestantes > 0)
                {
                    Console.Out.WriteLine("Autre résa (o/n) ?");
                    autreResa = Convert.ToChar(Console.In.ReadLine());
                }
            } while ((autreResa == 'O' || autreResa == 'o') && nbPlaceRestantes > 0);
            Console.Out.WriteLine("Billeterie fermée !");
            Console.In.ReadLine();
        }

        static void MainVoiture(string[] args)
        {
            Modele mod1, mod2, mod3;
            Voiture v1;
            Voiture[] tabVoit;
            string nom;
            int i,cpt;

            //mod1 = new Modele("Clio2", 12000);             // question 5
            mod1 = new Modele("Clio2", 12000, 1200);         // question 6
            /*
            v1 = new Voiture("1234 AB 79", 2011, 55000, mod1);
            v1.afficheInfos();
            Console.Out.WriteLine("Prix de base : " + v1.calculPrixDeBase());
            */
            // Question 7
            mod2 = new Modele("Espace", 32000, 3000);
            mod3 = new Modele("Twingo", 9900, 900);

            tabVoit = new Voiture[10];
            tabVoit[0] = new Voiture("1234 AB 79", 2011, 55000, mod1);
            tabVoit[1] = new Voiture("2345 AB 79", 2010, 60000, mod2);
            tabVoit[2] = new Voiture("3456 AB 79", 2009, 65000, mod3);
            tabVoit[3] = new Voiture("4567 AB 79", 2012, 25000, mod1);
            tabVoit[4] = new Voiture("5678 AB 79", 2013, 15000, mod2);
            tabVoit[5] = new Voiture("6789 AB 79", 2010, 65000, mod3);
            tabVoit[6] = new Voiture("7890 AB 79", 2008, 125000, mod1);
            tabVoit[7] = new Voiture("8901 AB 79", 2015, 5000, mod2);
            tabVoit[8] = new Voiture("9012 AB 79", 2013, 25000, mod3);
            tabVoit[9] = new Voiture("0123 AB 79", 2005, 155000, mod1);
            
            Console.Out.Write("Nom du modèle : ");
            nom = Console.In.ReadLine();
            cpt = 0;
            for (i = 0; i < tabVoit.Length; i++ )
            {
                if (tabVoit[i].getLeModele().getNomModele() == nom)
                {
                    Console.Out.WriteLine();
                    tabVoit[i].afficheInfos();
                    cpt++;
                }
            }
            if (cpt == 0)
                Console.Out.WriteLine("Aucune voiture de ce modèle !");
            
            // Question 8
            v1 = new Voiture("1234 AB 79", 2016, 75000, mod1, "d");
            v1.afficheInfos();


            Console.In.ReadLine();

        }

        public static Voiture charger(string nomFich)
        {
            Voiture voit=null;
            if (File.Exists(nomFich))
            {
                Stream TestFileStream = File.OpenRead(nomFich);
                BinaryFormatter deserializer = new BinaryFormatter();
                voit = (Voiture)deserializer.Deserialize(TestFileStream);
                TestFileStream.Close();
            }
            return voit;
        }

        public static void enregistrer(Voiture voit, string nomFich)
        {
            Stream TestFileStream = File.Create(nomFich);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, voit);
            TestFileStream.Close();
        }

  
    }
}
