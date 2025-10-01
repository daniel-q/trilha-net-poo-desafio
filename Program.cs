using DesafioPOO.Models;
Console.WriteLine("Nokia\n");

Nokia c1 = new Nokia("66666666", "n1", "1234567", 64);

c1.Ligar();
Console.WriteLine("");
c1.InstalarAplicativo("Calculadora");
Console.WriteLine("");

Console.WriteLine("Iphone\n");

Iphone c2 = new Iphone("77777777", "I1", "2345671", 32);

c2.Ligar();
Console.WriteLine("");
c2.InstalarAplicativo("Calculadora");