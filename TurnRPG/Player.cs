class Player : Character
{
    public Player(string name) : base(name)
    {
    }

    public override void ShowStat()
    {
        Console.WriteLine($"HP : {HpCur}/{HpMax}");
        Console.WriteLine($"MP : {MpCur}/{MpMax}");
    }
}