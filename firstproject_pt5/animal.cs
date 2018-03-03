using System;

namespace firstproject_pt5 {
    class Animal {

        public string name; // Our animals have names
        public string sound; // Our animals have sounds

        public Animal() {   // To give deafault values. 
            name="no name";
            sound="quiet";
            numberOfAnimals++;
        }

        /*      Another way to write the same thing.

        public Animal(string name = "no name", string sound = "quiet") {
            this.name=name;
            this.sound=sound;
            numberOfAnimals++;
        }
        */

        public void MakeSound() {   // So that the console is able to tell us about it
            Console.WriteLine("{0} says {1}.", name, sound);
        }

        static int numberOfAnimals = 0; // This is the same for EVERYTHING in this class. 
        
        public static int getNumberOfAnimals() {
            return numberOfAnimals;
        }

    }
}
