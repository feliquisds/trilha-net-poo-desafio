namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}
        public override void InstalarAplicativo(string app) => Console.WriteLine("Instalando {0} no Nokia...", app);
    }
}