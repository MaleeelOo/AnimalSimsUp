using System;
using System.Collections.Generic;
using System.Text;

namespace animalsimsup
{
    class Game
    {
        private int current_animal;
        public List<Animal> animals;

        public Game()
        {
            animals = new List<Animal>();
            animals.Add(new Katze());
            animals.Add(new Fisch());
            current_animal = 0;
        }

        public void update()
        {
            foreach (Animal animal in animals)
            {
                animal.timer();
            }
        }

        public void set_current_animal(int index)
        {
            current_animal = Math.Clamp(index, 0, animals.Count-1);
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
    }
}
