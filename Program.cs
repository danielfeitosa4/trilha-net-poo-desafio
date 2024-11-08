using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var celularNokia = new Nokia("1","Moto G", "12345", 268);
celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("Android");

Console.WriteLine("--------------------------------------------");

var celularIphone = new Iphone("2", "iPhone XR", "54321", 64);
celularNokia.Ligar();
celularNokia.ReceberLigacao();
celularNokia.InstalarAplicativo("iOS");