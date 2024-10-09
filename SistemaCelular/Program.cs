using SistemaCelular.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("12345678", "Modelo 1", "1111111111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("--------------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("87654321", "Modelo 2", "222222222222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
