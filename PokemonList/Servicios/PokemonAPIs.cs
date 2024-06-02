using Newtonsoft.Json;
using PokemonList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PokemonList.Models.ResourceList;

namespace PokemonList.Servicios
{
    public class PokemonAPIs
    {
        public HttpClient HttpClient;

        public PokemonAPIs()
        {
            HttpClient = new HttpClient();
        }

        public async Task<List<PokeInfo>> PokeList()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=40&offset=0";
            string json = await HttpClient.GetStringAsync(url);

            RosourceList resourceListPok = JsonConvert.DeserializeObject<RosourceList>(json);
            return resourceListPok.results;
        }

        public async Task<CaracteristicasPokemon> PokeCharacteristics(string url)
        {
            string json = await HttpClient.GetStringAsync(url);
            CaracteristicasPokemon pokeCharact = JsonConvert.DeserializeObject<CaracteristicasPokemon>(json);
            return pokeCharact;
        }

       
    }

}
