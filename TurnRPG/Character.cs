abstract class Character
{
    private string _name;

    protected int _hpMax;
    protected int _hpCur;

    protected int _mpMax;
    protected int _mpCur;

    private int _atk;
    private int _def;

    // public int HpMax
    // {
    //     get
    //     {
    //         return _hpMax;
    //     }
    // }
    public string Name { get => _name; set => _name = value; }

    public int HpMax { get => _hpMax; set => _hpMax = value; }
    public int HpCur { get => _hpCur; set => _hpCur = value; }

    public int MpMax { get => _mpMax; set => _mpMax = value; }
    public int MpCur { get => _mpCur; set => _mpMax = value; }

    public int Atk { get => _atk; set => _atk = value; }
    public int Def { get => _def; set => _def = value; }

    public Character(string name)
    {
        _name = name;
    }

    public void SetStat(int hp, int mp, int atk, int def)
    {
        _hpCur = hp;
        _hpMax = hp;

        _mpCur = mp;
        _mpMax = mp;

        _atk = atk;
        _def = def;
    }

    public void Attack(Character target)
    {
        Console.WriteLine($"{_name}의 공격!");
        Thread.Sleep(1000);
        
        int damage = _atk - target._def;
        if (damage < 1)
            damage = 1;

        target.TakeDamage(damage);
    }

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"{_name}은 {damage}의 데미지를 입었다");
        _hpCur -= damage;
    }

    public abstract void ShowStat();
}