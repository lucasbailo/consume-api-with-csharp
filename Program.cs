using System.Text.Json;
using NewScreenSound.Modelos;
using NewScreenSound.Filtros;

using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        var musicas = JsonSerializer.Deserialize<List <Musica>>(resposta)!;

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        
    }
    catch (Exception ex) { 
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}