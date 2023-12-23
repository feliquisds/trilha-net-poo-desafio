using DesafioPOO.Models;

Iphone iphone = new Iphone("91111-1111", "X", "000000000000000", 64);
Nokia nokia = new Nokia("92222-2222", "Y", "000000000000000", 32);

Console.WriteLine("Teste iPhone:");
Console.WriteLine("Número: " + iphone.Numero);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");

Console.WriteLine("\n");

Console.WriteLine("Teste Nokia:");
Console.WriteLine("Número: " + nokia.Numero);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");