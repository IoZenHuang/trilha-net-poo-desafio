namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - CONCLUÍDO
    public class Iphone : Smartphone
    {
        // Construtor necessário para passar as informações para a classe pai (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" - CONCLUÍDO
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nome}\" no iPhone...");
        }
    }
}
