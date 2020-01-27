using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input = Console.ReadLine();

            while (input != "Tournament")
            {
                //“<TrainerName> <PokemonName> <PokemonElement> <PokemonHealth>
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth =int.Parse( tokens[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer()
                {
                    Name = trainerName,
                    Badges = 0,
                    Pokemons = new List<Pokemon>()
                };

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = trainer;
                    trainers[trainerName].Pokemons.Add(pokemon);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(pokemon);
                }

                input = Console.ReadLine();
            }

            string element = Console.ReadLine();

            while (element != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == element)
                        {
                            trainer.Badges++;
                            break;
                        }
                        else
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health <= 0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                                break;
                            }
                        }
                    }
                }
                element = Console.ReadLine();
            }

            foreach (var item in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }
    }
}
