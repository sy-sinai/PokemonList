using PokemonList.Models;
using PokemonList.Servicios;
using System.Diagnostics;

namespace PokemonList;

public partial class ResumenPokemon : ContentPage
{

    CaracteristicasPokemon pokeCharact = new CaracteristicasPokemon();
  
    public ResumenPokemon(string url)
    {
        InitializeComponent();
        LoadPokeResume(url);
       
    }

    public async void LoadPokeResume(string url)
    {
        PokemonAPIs poke = new PokemonAPIs();
        pokeCharact = await poke.PokeCharacteristics(url);
        PokeImage.Source = pokeCharact.sprites.front_default;

        string abilities = "| ";
        foreach (var ability in pokeCharact.abilities)
        {
            abilities += ability.ability.name + " | ";
        }

        Abilitiess.Text = abilities;
    }

    

}