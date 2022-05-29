using System.Globalization;

decimal contabilities = 12.65m;
Console.WriteLine(contabilities);

decimal contabilitiesCulture = 12065m;
Console.WriteLine(
    contabilitiesCulture.ToString(
        "C", CultureInfo.CreateSpecificCulture("pt-BR")));

Console.WriteLine("================");

var mathRounding = 15987.56m;
Console.WriteLine(Math.Round(mathRounding));
Console.WriteLine(Math.Ceiling(mathRounding)); // (Ceiling up valor)
Console.WriteLine(Math.Floor(mathRounding)); // (Floor down valor)