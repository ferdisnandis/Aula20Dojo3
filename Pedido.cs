namespace Aula20Dojo3
{
    public class Pedido
    {
        public string[] itens { get;set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set;}
        public bool PedidoPago { get; set; }

        public string EntregarPedido(){
            if( PedidoPago == true && FormaDePGTO == "Cartão"){
            return "Pedido pago por cartão, entrega liberada";
            }
            else if( PedidoPago == true && FormaDePGTO == "Dinheiro" ){
                return "Pagamento vai ser feito por dinheiro na hora da entrega, entrega liberada";

            } return "Pagamento não efetuado";
        }
    }
}