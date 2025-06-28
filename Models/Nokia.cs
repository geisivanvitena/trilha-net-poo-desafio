namespace DesafioPOO.Models
{
    // Implementado
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei) : base(numero, modelo, imei)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Smartphone Nokia, instalando o aplicativo: {nomeApp}");
        }
    }
}