using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone(numero: "13-987654321", modelo: "Moto G52", imei: "1111111111", memoria: 128);
Console.WriteLine(iphone.ToString());
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Aplicativo para Iphone");
iphone.Ligar();

Smartphone nokia = new Nokia(numero: "47-123456789", modelo: "XIAOMI - 13C", imei: "22222222222", memoria: 64);
Console.WriteLine(nokia.ToString());
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Aplicativo para Nokia");
nokia.Ligar();

nokia.Memoria = 35;
Console.WriteLine(nokia);