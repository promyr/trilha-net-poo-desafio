using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "987654321", modelo: "Modelo 1", imei: "013285-7", memoria: 128);
nokia.Ligar();
nokia. InstalarAplicativo("Bet365");

Console.WriteLine("\n");

Console.WriteLine("iPhone XR");
Smartphone iphone = new Iphone(numero: "987452531", modelo: "Modelo 2", imei: "015499-8", memoria: 128);
iphone. ReceberLigacao();
iphone. InstalarAplicativo("Betano");