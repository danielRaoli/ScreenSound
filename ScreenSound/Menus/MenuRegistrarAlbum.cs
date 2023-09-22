using ScreenSound.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTitulo("Registrar Album");
            Console.WriteLine("Digite o nome da banda que deseja adicionar Album: \n");
            string nomeBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Console.WriteLine("Nome do album: ");
                string nomeAlbum = Console.ReadLine();
                Album album = new Album(nomeAlbum, bandasRegistradas[nomeBanda]);
                Console.WriteLine($"Album {album.Name} da banda {album.Banda} registrada");
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
