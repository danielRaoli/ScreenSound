
using ScreenSound.Entities;

namespace ScreenSound.Menus
{
    internal class Menu
    {
        public void ExibirTitulo(string titulo)
        {
            int qtdLetra = titulo.Length;
            string asteriscos = string.Empty.PadLeft(qtdLetra, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos);

        }

        public virtual void Executar(Dictionary<string, Banda> bandasRegistradas){
            Console.Clear();
        }

    }
}
