using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_4
{
    class Horaire
    {
        private int heure;
        private int minute;

        public int getHeure()
        { return heure; }

        public void setHeure(int heure)
        { this.heure = heure; }

        public int getMinute()
        { return minute; }

        public void setMinute(int minute)
        { this.minute = minute; }

        public Horaire(int heure, int minute)
        {
            this.heure = heure;
            this.minute = minute;
        }

        public String toString()
        { return this.heure + "H" + this.minute; }

    }
}
