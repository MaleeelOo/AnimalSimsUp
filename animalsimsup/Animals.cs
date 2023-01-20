using System;
using System.Collections.Generic;
using System.Text;

namespace animalsimsup
{
    abstract class Animal
    {
        // Attribute
        protected string name;
        protected int liebe;
        protected int essen;
        protected int schlaf;
        protected int sauberkeit;

        // Methoden
        public abstract void reduziere_liebe(int x);
        public abstract void reduziere_essen(int x);
        public abstract void reduziere_schlaf(int x);
        public abstract void reduziere_sauberkeit(int x);

        public abstract void hinzufuegen_liebe(int x);
        public abstract void hinzufuegen_essen(int x);
        public abstract void hinzufuegen_schlaf(int x);
        public abstract void hinzufuegen_sauberkeit(int x);

        public abstract int get_liebe();
        public abstract int get_essen();
        public abstract int get_schlaf();
        public abstract int get_sauberkeit();
    }

    class Katze : Animal
    {
        public Katze()
        {
            name = "Katze";
            liebe = 100;
            essen = 100;
            schlaf = 100;
            sauberkeit = 100;
        }
        public override void reduziere_liebe(int x)
        {
            liebe -= x;
        }

        public override void reduziere_essen(int x)
        {
            essen -= x;
        }
        public override void reduziere_schlaf(int x)
        {
            schlaf -= x;
        }
        public override void reduziere_sauberkeit(int x)
        {
            sauberkeit -= x;
        }

        public override void hinzufuegen_liebe(int x)
        {
            liebe += x;
        }
        public override void hinzufuegen_essen(int x)
        {
            essen += x;
        }
        public override void hinzufuegen_schlaf(int x)
        {
            schlaf += x;
        }
        public override void hinzufuegen_sauberkeit(int x)
        {
            sauberkeit += x;
        }

        public override int get_liebe()
        {
            return liebe;
        }

        public override int get_essen()
        {
            return essen;
        }

        public override int get_sauberkeit()
        {
            return sauberkeit;
        }

        public override int get_schlaf()
        {
            return liebe;
        }
    }
}
