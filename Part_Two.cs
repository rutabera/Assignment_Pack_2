using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Pack_2
{
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Animal(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

    // List of animals and their descriptions
    static List<Animal> animals = new List<Animal>
    {
        new Animal("Giraffe", "It has a long neck and likes to eat leaves."),
        new Animal("Elephant", "It has big ears and a trunk, and it is the largest land animal."),
        new Animal("Penguin", "It is a bird that can't fly, lives in cold places, and waddles when it walks."),
        new Animal("Kangaroo", "It has strong hind legs and carries its young in a pouch."),
        new Animal("Lion", "It is known as the 'King of the Jungle' and has a large mane."),
    };

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Animal Description Match Game!");

            // Game loop
            bool gameRunning = true;
            while (gameRunning)
            {
                // Randomly pick an animal description
                Random rand = new Random();
                int animalIndex = rand.Next(animals.Count);
                var selectedAnimal = animals[animalIndex];

                // Give the user the description of the animal
                Console.WriteLine($"Description: {selectedAnimal.Description}");
                Console.WriteLine("What animal is this?");

                // Get user's guess
                string userGuess = Console.ReadLine();

                // Check if the user's guess matches the correct animal
                if (userGuess.Trim().ToLower() == selectedAnimal.Name.ToLower())
                {
                    Console.WriteLine($"Correct! The animal is a {selectedAnimal.Name}.");
                }
                else
                {
                    Console.WriteLine($"Oops! The correct answer is {selectedAnimal.Name}.");
                }

                // Ask if the user wants to play again
                Console.WriteLine("Do you want to try again? (yes/no)");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "yes")
                {
                    gameRunning = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    } }
