

using ScreenSound.Entities;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda : Menu
    {

        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Registrar banda:\n");
            Console.WriteLine("Digite o nome da banda a ser registrada: ");
            string name = Console.ReadLine();
            Banda banda = new(name);
            if(bandasRegistradas.ContainsKey(name))
            {
                Console.WriteLine("A banda já está registrada");
            }
            else
            {
                bandasRegistradas.Add(banda.Name, banda);
            }
           

        }

    }
}
