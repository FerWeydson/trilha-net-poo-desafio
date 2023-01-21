using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Testando Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123123222", modelo: "Nokia 21", imei: "299999999", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

System.Console.WriteLine("\n");

System.Console.WriteLine("Testando Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "321321333", modelo: "Iphone xx12", imei: "488888888", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");