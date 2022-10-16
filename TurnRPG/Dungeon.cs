class Dungeon : Placement
{
    List<Monster> _monsters;

    public event System.Action BackToTownAction;
    
    public Dungeon(string name) : base(name)
    {
        _monsters = new List<Monster>();
        Monster monster;

        monster = new Monster("슬라임");
        monster.SetStat(hp: 10, mp: 0, atk: 1, def: 1);
        _monsters.Add(monster);

        monster = new Monster("주황버섯");
        monster.SetStat(hp: 20, mp: 0, atk: 5, def: 2);
        _monsters.Add(monster);

        monster = new Monster("발록");
        monster.SetStat(hp: 100, mp: 100, atk: 50, def: 30);
        _monsters.Add(monster);
    }

    public override void ShowInterface()
    {
        Monster curMonster;
        int level = 1;
        while(true)
        {
            curMonster = _monsters[level - 1];
            // 인스턴스를 재사용하다보니 체력이 닳아있을 수 있음.
            curMonster.Reset();

            // 배틀.
            while(true)
            {
                Console.Clear();
                Console.WriteLine($"레벨 {level}");

                Console.WriteLine(curMonster.Name);
                curMonster.ShowStat();

                Console.WriteLine(_player.Name);
                _player.ShowStat();

                Console.WriteLine("1.공격하기, 2.도망가기");
                string input = InputManager.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    _player.Attack(curMonster);
                    Thread.Sleep(1000);
                    if (curMonster.HpCur <= 0)
                    {
                        Console.WriteLine($"{curMonster.Name}은(는) 쓰러졌다");
                        Thread.Sleep(2000);
                        break;
                    }
                    // 실습.
                    curMonster.Attack(_player);
                    Thread.Sleep(1000);
                    if (_player.HpCur <= 0)
                    {
                        Console.WriteLine($"{_player.Name}은(는) 쓰러졌다");
                        Thread.Sleep(2000);
                        break;
                    }
                }
                else
                {
                    // _place = Place.Town;
                    BackToTownAction();
                    return;
                }

            }

            Console.Clear();

            // 몬스터를 잡으면.
            if (_player.HpCur > 0)
            {
                if (level == 3)
                {
                    Console.WriteLine("던전 클리어!");
                    Console.Write("마을로 돌아가기");
                    Console.ReadLine();
                    // _place = Place.Town;
                    BackToTownAction();
                    return;
                }
                else
                {
                    // 간단한 실습.
                    Console.WriteLine("레벨 클리어");
                    Console.WriteLine("1.다음 단계, 2.마을로 돌아가기");
                    string input = InputManager.ReadLine();
                    if (input == "1")
                    {
                        level++;
                        continue;
                    }
                    else
                    {
                        // _place = Place.Town;
                        BackToTownAction();
                        return;
                    }
                }
            }
            else
            {
                // 간단한 실습.
                Console.WriteLine("눈앞이 깜깜해졌다..");
                Console.Write("마을로 돌아가기");
                Console.ReadLine();
                // _place = Place.Town;
                BackToTownAction();
                return;
            }
        }
    }
}