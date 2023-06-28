using ScreenSoundv4.Modelos;

namespace ScreenSoundv4.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)
                .Select(musica => musica.Artista)
                .Distinct()
                .ToList();
            Console.WriteLine("Lista de artistas ordenados");
            foreach(var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
