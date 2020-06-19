using System;
using fernanda1234.Desktop.Aula20Dojo3;

namespace Aula20Dojo3
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Nota Fiscal");
            System.Console.WriteLine();

            Cliente cliente = new Cliente("Maria Joaquina");
            cliente.EnderecoAtual = "Rua das Oliveiras, 666";
           System.Console.WriteLine( cliente.MostrarDadosCliente() ); 

            Restaurante restaurante = new Restaurante("Lanchão do Fabinho");
            restaurante.Endereco = "Rua Jardins, 159";
            System.Console.WriteLine( restaurante.MostrarDadosRestaurante() );

            Pedido pedido = new Pedido();
            
            string[] itens = {"X-Tudo", "Refrigerante", "Batata Frita"} ;
            pedido.FormaDePGTO = "Cartão";
            pedido.PedidoPago = true;
            
            System.Console.WriteLine();
            //Itens
            System.Console.WriteLine("Itens do pedido: ");
            System.Console.WriteLine( itens[0] );
            System.Console.WriteLine( itens[1] );
            System.Console.WriteLine( itens[2] );
            System.Console.WriteLine();
            //Forma de pagamento
            System.Console.WriteLine($"Forma de Pagamento {pedido.FormaDePGTO}");
            System.Console.WriteLine( pedido.EntregarPedido() );
        }
    }
}
