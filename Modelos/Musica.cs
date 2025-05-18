
using System.Text.Json.Serialization;

namespace NewScreenSound.Modelos
{
    internal class Musica
    {
        private string[] tonalidades =
        {
            "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
        };

        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("key")]
        public int TomKey {  get; set; }

        public string Tonalidae { 
            get 
            {
                return tonalidades[TomKey];
            }
        }


        public void ExibirDetalhesDaMusica () {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duracao: {Duracao/1000}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Tonalidade: {Tonalidae}");
        }
    }
}
