

using ScreenSound.Entities;

namespace ScreenSound.Interfaces
{
    internal interface IAvaliavel
    {

        public double Media {  get; }
        public void AddAvalicao(Avaliacao avalicao);
    }
}
