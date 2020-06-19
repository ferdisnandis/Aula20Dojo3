namespace fernanda1234.Desktop.Aula20Dojo3
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string EnderecoAtual { get; set; }

         public Cliente(string _nome){
            this.NomeCliente = _nome;
        }

        public string MostrarDadosCliente(){
            return $"Cliente: {NomeCliente} \nEndereço: {EnderecoAtual}";
        }
    }
}