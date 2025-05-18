using System.Text.Json;
using NewScreenSound.Modelos;
using NewScreenSound.Filtros;

using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        var musicas = JsonSerializer.Deserialize<List <Musica>>(resposta)!;

        //musicas[2].ExibirDetalhesDaMusica();

        //LinqFilter.FiltrarMusicasPeloTom(musicas, "C#");

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        //var musicasPreferidasDoUsuario = new MusicasPreferidas("Carlos");
        //musicasPreferidasDoUsuario.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoUsuario.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoUsuario.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoUsuario.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoUsuario.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoUsuario.ExibirMusicasFavoritas();

        //musicasPreferidasDoUsuario.GerarArquivoJson();

    }
    catch (Exception ex) { 
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}