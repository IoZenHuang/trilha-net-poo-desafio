namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedade pública conforme o diagrama (+)
        public string Numero { get; set; }

        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        // Ajustamos o construtor para receber todos os parâmetros necessários
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}
