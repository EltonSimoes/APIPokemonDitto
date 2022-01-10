using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.Controlles
{
    public class PokemonController : Controller
    {
        private DataContext dc;

        public PokemonController(DataContext context)
        {
            dc = context;
        }

        [HttpPost("Criar Pokemon")]
        public async Task<ActionResult> cadastrarPokemon(string Nome, int Idade, int Cpf)
        {
            PokemonDittoList pokemon = new PokemonDittoList();
            pokemon.NamePokemon = Nome;
            pokemon.IdaddePokemon = Idade;
            pokemon.CPFPokemon = Cpf;
            dc.pokemon.Add(pokemon);
            await dc.SaveChangesAsync();

            return Created("Objeto pokemon", pokemon);
        }

        [HttpGet("Lista Pokemon")]
        public async Task<List<Species>> getListPokemon()
        {
            Random rnd = new Random();
            List<Species> speciesReturn = new List<Species>();
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/ditto") };
            var response = await client.GetAsync("Podemon");
            var content = await response.Content.ReadAsStringAsync();
            JsonConvert.DeserializeObject(content);
            var species = JsonConvert.DeserializeObject<Species[]>(content);
            for (int i = 0; i < 10; i++)
            {
                int r = rnd.Next(species.Count());
                speciesReturn.Add(species[r]);
            }

            return speciesReturn;
        }

        [HttpGet("Pokemon")]
        public async Task<Species> Species(String nome)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/ditto") };
            var response = await client.GetAsync("Podemon");
            var content = await response.Content.ReadAsStringAsync();

            var species = JsonConvert.DeserializeObject<Species[]>(content);
            var returnPoke = species.First(x => x.Name == nome);

            return returnPoke;
        }
    }
}
