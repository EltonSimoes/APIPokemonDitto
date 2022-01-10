using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PokemonDittoList
    {
        [Key]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string NamePokemon { get; set; }
        public int IdaddePokemon { get; set; }
        public int CPFPokemon { get; set; }
        public long BaseExperience { get; set; }
        public long Height { get; set; }
        public bool IsDefault { get; set; }
        public long Order { get; set; }
        public long Weight { get; set; }

        public List<TypeElement> Types { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<Species> Forms { get; set; }
        public List<GameIndex> GameIndices { get; set; }
        public List<HeldItem> HeldItems { get; set; }
        public Uri LocationAreaEncounters { get; set; }
        public List<Move> Moves { get; set; }
        public List<object> PastTypes { get; set; }
        public Species Species { get; set; }
        public Sprites Sprites { get; set; }
        public List<Stat> Stats { get; set; }
    }
}
