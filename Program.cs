using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");




Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "987654", modelo: "modelo 2", imei: "2222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");