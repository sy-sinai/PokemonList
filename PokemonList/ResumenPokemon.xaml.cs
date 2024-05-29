using PokemonList.Models;
using PokemonList.Servicios;
using System.Diagnostics;

namespace PokemonList;

public partial class ResumenPokemon : ContentPage
{ 

	public ResumenPokemon()
	{
		InitializeComponent();
	}

    public async void CargaPokemon(string url)
    {
        PokemonAPIs poke_services = new PokemonAPIs();
        caracteristicas ? await poke_services.DevuelveCaracteristicasPokemon(url);
        Debug.WriteLine(JsonConvert.SerializeObject(caracteristicas));

    }


}