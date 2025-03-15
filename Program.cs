string fraseDigitada;

Console.Write("Digite uma flase: ");
fraseDigitada = Console.ReadLine()!
    .Replace("r", "l")
    .Replace("R", "L");

Console.WriteLine($"{fraseDigitada}");