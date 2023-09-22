using ScreenSound.Interfaces;
using System;


namespace ScreenSound.Entities
{
    public class Musica : IAvaliavel
    {
        public string Name { get; set; }
        public Banda Banda { get; private set; }

        public int Duration { get; set; }

        public bool Disponivel { get; set; }

        private readonly List<Avaliacao> notas = new List<Avaliacao>();

        public string Descricao => $"Nome {Name} - Banda/Cantor {Banda.Name} -Classificação: {Media}";

        public double Media => notas.Average(nota => nota.Nota);

        public Musica(string name, Banda banda)
        {
            Name = name;
            Banda = banda;
            Banda.AddMusicaBanda(this);
        }

        public override string ToString()
        {
            return Descricao + $"Duration {Duration}";
        }

        void IAvaliavel.AddAvalicao(Avaliacao avalicao)
        {
            notas.Add(avalicao);
        }
    }
}
