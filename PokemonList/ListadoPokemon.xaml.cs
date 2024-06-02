namespace PokemonList;

public partial class ListadoPokemon : ContentPage
{
    public List<PokeInfo> pokeInfos;
    public ListPokemon()
    {

        InitializeComponent();
        LoadPoke();
    }

    public async void LoadPoke()
    {
        PokeService poke = new PokeService();
        pokeInfos = await poke.PokeList();
        pokeInfoss.ItemsSource = pokeInfos;
    }

    public void ShowPokeResume(object sender, SelectedItemChangedEventArgs e)
    {
        PokeInfo pokeInfo = (PokeInfo)e.SelectedItem;
        Navigation.PushAsync(new Pages.PokeResume(pokeInfo.url));
    }

}