const string SrcPath = "..\\..\\..\\res\\toto.txt";

List<Fordulo> totoFordulok = [];

using StreamReader sr = new(SrcPath);
_ = sr.ReadLine();
while (!sr.EndOfStream)
    totoFordulok.Add(new(sr.ReadLine().Split(';')));

Console.WriteLine($"fordulok szama: {totoFordulok.Count}");

var sumTT = totoFordulok.Sum(f => f.Telitalalatok);
Console.WriteLine($"telitalalatos szelvenyek szama: {sumTT}");

var avgKifizetes = totoFordulok
    .Where(f => f.VoltTelitalalat)
    .Average(f => f.Nyeremeny * f.Telitalalatok);
Console.WriteLine($"kifizetesek atlaga: {avgKifizetes:0}");

var maxNyeremenyF = totoFordulok
    .MaxBy(f => f.Nyeremeny);
Console.WriteLine($"legnagyobb nyeremeny:\n{maxNyeremenyF}");

var minNyeremenyF = totoFordulok
    .Where(f => f.VoltTelitalalat)
    .MinBy(f => f.Nyeremeny);
Console.WriteLine($"legkisebb nyeremeny:\n{minNyeremenyF}");

var vhnvDontetlen = totoFordulok.Any(f => f.NemVoltDontetlen);
Console.WriteLine($"{(vhnvDontetlen ? "volt" : "nem volt")} dontetlen nelkuli fordulo");