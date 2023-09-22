using ScreenSound.Interfaces;
using System;
using System.Text;
using System.Threading.Channels;

namespace ScreenSound.Entities
{
    public class Banda : IAvaliavel
    {
        public string Name { get; set; }

        private readonly List<Avaliacao> notas = new();

        public double Media => notas.Average(nota => nota.Nota) ;

        private readonly List<Musica> musicas = new ();
        private readonly List<Album> albums = new ();
       

        public Banda(string name)
        {
            Name = name;
        }


        public void AddMusicaBanda(Musica musica)
        {
            musicas.Add(musica);
        }

        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringMusicas = new StringBuilder();
            foreach (var album in albums)
            {
                stringBuilder.AppendLine(album.Name.ToString());
            }
            foreach (var musica in musicas)
            {
                stringMusicas.AppendLine(musica.Name.ToString());
            }
            return $"Banda: {Name} " +
            $"Discografia:\n{stringBuilder}" +
            $"Musicas:\n {stringMusicas}" +
            $"Classificação: {Media} ";
            
               
        }

        void IAvaliavel.AddAvalicao(Avaliacao avalicao)
        {
            throw new NotImplementedException();
        }
    }
}
