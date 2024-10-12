using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("12351", modelo: "Mkio", imei: "546k", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("App 01");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("+5581599", modelo: "inoei", imei: "jo54", memoria: 1233);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");



