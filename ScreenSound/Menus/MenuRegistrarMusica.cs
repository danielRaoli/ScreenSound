

using ScreenSound.Entities;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarMusica : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Registrar Música");
            Console.WriteLine("Digite o nome da banda que deseja adicionar música: \n");
            string nomeBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Console.WriteLine("Nome da música: ");
                string nomeMusica = Console.ReadLine();
                Musica musica = new Musica(nomeMusica, bandasRegistradas[nomeBanda]);
                Console.WriteLine($"Musica {musica.Name} da banda {musica.Banda} registrada");
                Thread.Sleep(4000);
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Banda Não registrada\n " +
                "Aperte uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
