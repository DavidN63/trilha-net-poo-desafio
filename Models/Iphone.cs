using DesafioPOO.Models;

Console.WriteLine("Smartphone Nókia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar(); // Corrigido para o método Ligar
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "modelo 2", imei: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
