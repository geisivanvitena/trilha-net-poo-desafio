namespace DesafioPOO.Models
{
    // Implementado
    public class Iphone : Smartphone
    {
        // Implementado

        public Iphone(string numero, string modelo, string imei) : base(numero, modelo, imei)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Smartphone Iphone, instalando o aplicativo: {nomeApp}");
        }
    }
}