namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string model, string imei, int memoria) : base(numero, model, imei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no seu Iphone...\n{nomeApp} instalado(a)");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}