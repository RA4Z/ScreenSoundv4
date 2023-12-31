﻿using ScreenSoundv4.Modelos;
using System.Text.Json;
using ScreenSoundv4.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Kiss");

        var musicasPreferidasDoRobert = new MusicasPreferidas("Robert");
        musicasPreferidasDoRobert.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoRobert.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidasDoRobert.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoRobert.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoRobert.AdicionarMusicasFavoritas(musicas[1467]);

        musicasPreferidasDoRobert.ExibirMusicasFavoritas();
        musicasPreferidasDoRobert.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}