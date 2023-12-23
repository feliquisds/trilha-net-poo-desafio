namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}
        public override void InstalarAplicativo(string app) => Console.WriteLine("Instalando {0} no iPhone...", app);
    }
}