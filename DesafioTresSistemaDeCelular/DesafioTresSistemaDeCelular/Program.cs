using DesafioTresSistemaDeCelular.Models;
using System.Net.Http.Headers;

Console.WriteLine("Smartphone Nokia");
Smartphone N = new Nokia("123456","Modelo 1","111111111",64);
N.Ligar();
N.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone I = new Iphone("654321","Modelo 2","222222222",128);
I.ReceberLigacao();
I.InstalarAplicativo("Telegram");