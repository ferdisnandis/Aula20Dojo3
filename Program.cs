using System;
using fernanda1234.Desktop.Aula20Dojo3;

namespace Aula20Dojo3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Cliente cliente = new Cliente("Maria Joaquina");
            System.Console.WriteLine("Digite endereço da entrega:");
            cliente.EnderecoAtual = Console.ReadLine();
            System.Console.WriteLine();
           System.Console.WriteLine( cliente.MostrarDadosCliente() ); 


            Restaurante restaurante = new Restaurante("Lanchão do Fabinho");
            restaurante.Endereco = "Rua Jardins, 159";
            System.Console.WriteLine( restaurante.MostrarDadosRestaurante() );

            Pedido pedido = new Pedido();


             for (int i = 0; i < 2; i++)
            {
                System.Console.WriteLine("Digite um item");
                pedido.itens[i] = Console.ReadLine();
            }



             System.Console.WriteLine("Itens do pedido: ");
            System.Console.WriteLine( pedido.itens[0] );
            System.Console.WriteLine( pedido.itens[1] );
            System.Console.WriteLine( pedido.itens[2] );
            System.Console.WriteLine();

            System.Console.WriteLine("Digite a forma de pagamento: ");
            pedido.FormaDePGTO = Console.ReadLine();
            pedido.PedidoPago = true;
            
            //Forma de pagamento
            System.Console.WriteLine($"Forma de Pagamento {pedido.FormaDePGTO}");
            System.Console.WriteLine( pedido.EntregarPedido() );
        }
    }
}
