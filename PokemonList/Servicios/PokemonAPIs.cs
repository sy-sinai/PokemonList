using PokemonList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonList.Servicios
{
    public class PokemonAPIs
    {
        public HttpClient _httpClient;
        public PokemonAPIs()
        {
            _httpClient = new HttpClient();
        }

        public async List<PokemonInfo> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/ability/?limit=40&offset=0";
            string json = await _httpClient.GetStringAsync(url);
        }
    }

}
