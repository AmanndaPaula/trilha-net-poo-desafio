using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 6820", imei:
 "111111111", memoria: 64);
 nokia.Ligar();
nokia.InstalarAplicativo("Spotify");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Iphone 5", imei: 
"22222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagran");
iphone.ReceberLigacao();