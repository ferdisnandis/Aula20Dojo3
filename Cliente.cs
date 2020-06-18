namespace fernanda1234.Desktop.Aula20Dojo3
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public string MostrarDadosCliente(){
            return $"Cliente: {Nome} \nEndereço: {EnderecoAtual}";
        }
    }
}