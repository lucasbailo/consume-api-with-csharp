using NewScreenSound.Modelos;

namespace NewScreenSound.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas) 
    {
        var artistasOrdenados = musicas.OrderBy(x => x.Artista).Select(x => x.Artista).Distinct().ToList();
        Console.WriteLine("Lista de Artistas Ordenados: \n");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}

