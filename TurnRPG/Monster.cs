using System.Text;

class Monster : Character
{
    public Monster(string name) : base(name)
    {
    }

    public override void ShowStat()
    {
        Console.WriteLine("HP : [||||||||||||]");

    }
}