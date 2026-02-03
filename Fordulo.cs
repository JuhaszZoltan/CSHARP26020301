class Fordulo
{
    public int Ev { get; set; }
    public int Het { get; set; }
    public int Sorszam { get; set; }
    public int Telitalalatok { get; set; }
    public int Nyeremeny { get; set; }
    public string Eredmenyek { get; set; }
    public bool VoltTelitalalat => Telitalalatok > 0 || Nyeremeny > 0;

    public bool NemVoltDontetlen => !Eredmenyek.ToUpper().Contains("X");

    public override string ToString() =>
        $"\tÉv: {Ev}\n" +
        $"\tHét: {Het}.\n" +
        $"\tForduló: {Sorszam}.\n" +
        $"\tTelitalálat: {Telitalalatok} db\n" +
        $"\tNyeremény: {Nyeremeny} Ft\n" +
        $"\tEredmények: {Eredmenyek}";

    public Fordulo(string[] v)
    {
        Ev = int.Parse(v[0]);
        Het = int.Parse(v[1]);
        Sorszam = int.Parse(v[2]);
        Telitalalatok = int.Parse(v[3]);
        Nyeremeny = int.Parse(v[4]);
        Eredmenyek = v[5];
    }
}
