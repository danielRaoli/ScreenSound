using ScreenSound.Interfaces;
using System;

namespace ScreenSound.Entities
{
    public class Album : IAvaliavel
    {
        public Banda Banda { get; private set; }
        public string Name { get; set; }

        private readonly List<Musica> musicas = new();
        public int TotalMinutes => musicas.Sum(musica => musica.Duration);

        private List<Avaliacao> notas { get; } = new();

        public double Media => notas.Average(avalia => avalia.Nota) ;

        public Album(string name, Banda banda)
        {
            Name = name;
            Banda = banda;
            Banda.AddAlbum(this);
        }

        public void AddMusicaAlbum(Musica musica)
        {
            musicas.Add(musica);
            musica.Banda.AddMusicaBanda(musica);
        }

        void IAvaliavel.AddAvalicao(Avaliacao avalicao)
        {
            notas.Add(avalicao);
        }
    }
}
