using Newtonsoft.Json;
using PokemonList.Models;
using PokemonList.Servicios;
using System.Diagnostics;
namespace PokemonList;

public partial class ListadoPokemon : ContentPage
{
    public List<PokeInfo> pokeInfos;
    public ListadoPokemon()
    {

        InitializeComponent();
        LoadPoke();
    }

    public async void LoadPoke()
    {
        PokemonAPIs poke = new PokemonAPIs();
        pokeInfos = await poke.PokeList();
        pokeInfoss.ItemsSource = pokeInfos;
    }

    public void ShowPokeResume(object sender, SelectedItemChangedEventArgs e)
    {
        PokeInfo pokeInfo = (PokeInfo)e.SelectedItem;
        Navigation.PushAsync(new ResumenPokemon(pokeInfo.url));
    }

}