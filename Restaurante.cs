namespace fernanda1234.Desktop.Aula20Dojo3
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }
        public string Endereco { get; set; }

        public string MostrarDadosRestaurante(){
            return $"Restaurante {NomeRestaurante} \nEndereço: {Endereco}";
        }
    }
}