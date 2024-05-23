using DesafioPOO.Models;


namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", "16GB");
            Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", "128GB");

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}



