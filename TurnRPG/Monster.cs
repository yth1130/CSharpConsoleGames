using System.Text;

class Monster : Character
{
    public Monster(string name) : base(name)
    {
    }

    public override void ShowStat()
    {
        // Console.WriteLine("HP : [||||||||||||]");
        int barNum;
        string str;

        barNum = (int)((_hpCur / (float)_hpMax) * 10f);
        str = "HP : [";
        for (int i = 0; i < barNum; i++)
        {
            str += "|";
        }
        for (int i = barNum; i < 10; i++)
        {
            str += " ";
        }
        str += "]";
        Console.WriteLine(str);

        if (_mpMax == 0)
            return;

        barNum = (int)((_mpCur / (float)_mpMax) * 10f);
        str = "MP : [";
        for (int i = 0; i < barNum; i++)
        {
            str += "|";
        }
        for (int i = barNum; i < 10; i++)
        {
            str += " ";
        }
        str += "]";
        Console.WriteLine(str);
    }
}