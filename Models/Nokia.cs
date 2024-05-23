namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.Imei = imei;
            this.Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Sobrescrever o método "InstalarAplicativo"
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone...");
        }
    }
}
