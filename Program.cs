using DesafioPOO.Models;

// Implementado

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "12345", modelo: "Nokia 3310", imei: "223377");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "555", modelo: "Iphone xsc", imei: "88888");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");