namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedade pública conforme o diagrama (+)
        public string Numero { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama - CONCLUÍDO
        // Usamos private pois no diagrama estão com o sinal de "-"
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        // Ajustamos o construtor para receber todos os parâmetros necessários
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades - CONCLUÍDO
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
