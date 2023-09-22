

using ScreenSound.Entities;

namespace ScreenSound.Menus
{
    internal  class MenuAvaliarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            Console.WriteLine("Digite o nome da banda que deseja avaliar: \n");
            string nomeBanda = Console.ReadLine();  

        }
    }
}
