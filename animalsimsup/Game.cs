using System;
using System.Collections.Generic;
using System.Text;

namespace animalsimsup
{
    class Game
    {
        private Time t;
        private double elapsed_time; 
        private int current_animal;
        public static List<Animal> animals;
        public static Game game;

        public Game()
        {
            t = new Time();
            animals = new List<Animal>();
            animals.Add(new Katze());
            elapsed_time = 0.0;
            current_animal = 0;

            game = this;
        }

        public void update()
        {
            elapsed_time = t.get_elapsed_time();

            foreach(Animal animal in animals)
            {
                animal.reduziere_essen(Convert.ToInt32(elapsed_time));
                animal.reduziere_liebe(Convert.ToInt32(elapsed_time));
                animal.reduziere_sauberkeit(Convert.ToInt32(elapsed_time));
                animal.reduziere_schlaf(Convert.ToInt32(elapsed_time));
            }

        }

        public void kaufen()
        {

        }

        public void verkaufen()
        {

        }

        public void nahrung()
        {
            if(current_animal < animals.Count)
            {
                animals[current_animal].hinzufuegen_essen(5);
            }
        }

        public void liebe()
        {
            if (current_animal < animals.Count)
            {
                animals[current_animal].hinzufuegen_liebe(5);
            }
        }

        public void putzen()
        {
            if (current_animal < animals.Count)
            {
                animals[current_animal].hinzufuegen_sauberkeit(5);
            }
        }

        public int get_current_animal_liebe()
        {
            return animals[current_animal].get_liebe();
        }

        public int get_current_animal_essen()
        {
            return animals[current_animal].get_essen();
        }

        public int get_current_animal_schlaf()
        {
            return animals[current_animal].get_schlaf();
        }

        public int get_current_animal_sauberkeit()
        {
            return animals[current_animal].get_sauberkeit();
        }
    }
}
