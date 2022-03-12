String nome, sobrenome, sobrenomeM;
Console.Write("Digite seu primeiro nome: ");
nome=Console.ReadLine()!;

Console.Write("Digite seu segundo nome: ");
sobrenome=Console.ReadLine()!;

sobrenomeM=sobrenome.ToUpper();

Console.WriteLine($"Nome completo: {nome} {sobrenome}");

Console.WriteLine($"Nome de catálogo: {sobrenomeM}, {nome}");