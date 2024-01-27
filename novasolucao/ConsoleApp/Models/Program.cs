using DesafioPOO.Models;

Nokia c1 = new Nokia(numero: "2345", modelo: "tipo1", imei: "abcs", memoria: 64);
Console.WriteLine(c1.Ligar("2345"));
Console.WriteLine(c1.InstalarAplicativoValidando("Spotify", 62));
Console.WriteLine(c1.ReceberLigacao("988882222"));
Console.WriteLine(c1.RegistrarVideo(12));
Console.WriteLine(c1.ApresentarMemoria(14));

Iphone c2 = new Iphone(numero: "56748", modelo: "tipo3", imei: "gdhgf", memoria: 128);
Console.WriteLine(c2.Ligar("56748"));
Console.WriteLine(c2.ReceberLigacao("667809"));
Console.WriteLine(c2.InstalarAplicativoValidando("Instagram", 34));
Console.WriteLine(c2.RegistrarVideo(6));
