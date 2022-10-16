class MainGame
{
    enum Place
    {
        None,
        Town,
        Shop,
        Dungeon,
    }

    TitleScreen _titleScreen;

    // Place _place;
    Player _player;
    List<Monster> _monsters;

    Placement _curPlacement;
    Town _town;
    Dungeon _dungeon;

    bool _exitGame;

    // 생성자 추가.
    public MainGame()
    {
        _titleScreen = new TitleScreen();
        // _place = Place.Town;

        _player = new Player(name: "주인공");
        _player.SetStat(hp: 100, mp: 100, atk: 5, def: 5);

        _monsters = new List<Monster>();

        _town = new Town("마을");
        _town.ExitGameAction += () => _exitGame = true;
        _town.GoToDungeonAction += () =>
        {
            ChangePlacement(_dungeon);
        };

        _dungeon = new Dungeon("던전");
        _dungeon.BackToTownAction += () =>
        {
            ChangePlacement(_town);
        };

        _curPlacement = null;
        _exitGame = false;
    }
    
    // public void ShowTitle()
    // {
    //     Console.Clear();
    //     Console.WriteLine("턴제 RPG 게임");
    //     Console.WriteLine("1.게임시작");

    //     // Console.Write(">");
    //     // string input = Console.ReadLine();

    //     string input = InputManager.ReadLine();
    //     // 인게임 진입.
    //     if (input == "1")
    //     {
    //         Play();
    //     }
    // }

    public void Start()
    {
        _titleScreen.Show(startAction: () =>
        {
            ChangePlacement(_town);
            Play();
        });

        // _curPlacement = _town;
        // _titleScreen.Show(startAction: Play);
    }

    // 상점.
    // 던전 : 계속 몬스터들이 나오고 다 잡으면 던전 빠져나오기.
    public void Play()
    {
        // while (_place != Place.None)
        // {
        //     switch(_place)
        //     {
        //         case Place.Town: ShowTown(); break;
        //         // 간단한 실습.
        //         case Place.Shop: ShowShop(); break;
        //         case Place.Dungeon: ShowDungeon(); break;
        //     }
        // }

        while(true)
        {
            _curPlacement.ShowInterface();
            if (_exitGame == true)
            {
                break;
            }
        }
    }

    void ChangePlacement(Placement nextPlacement)
    {
        _curPlacement = nextPlacement;
        _curPlacement.Enter(_player);
    }

    // public void ShowTown()
    // {
    //     Console.Clear();
    //     Console.WriteLine("마을");
    //     Console.WriteLine("1.상점가기, 2.던전가기, 3.스탯보기, 4.게임종료");
    //     string input = InputManager.ReadLine();

    //     if (input == "1")
    //     {
    //         _place = Place.Shop;
    //         return;
    //     }
    //     if (input == "2")
    //     {
    //         _place = Place.Dungeon;
    //         return;
    //     }
    //     if (input == "3")
    //     {
    //         Console.Clear();
    //         _player.ShowStat();
    //         Console.Write("\n돌아가기");
    //         Console.ReadLine();
    //         return;
    //     }
    //     if (input == "4")
    //     {
    //         _place = Place.None;
    //         return;
    //     }
    // }

    // public void ShowShop()
    // {
    //     while(true)
    //     {
    //         Console.Clear();
    //         Console.WriteLine("상점");
    //         Console.WriteLine("1.구입, 2.판매, 3.나가기");
    //         string input = InputManager.ReadLine();

    //         if (input == "3")
    //         {
    //             _place = Place.Town;
    //             break;
    //         }
    //     }
    // }

    // public void ShowDungeon()
    // {
    //     Console.Clear();
    //     Console.WriteLine("던전 입장");
    //     Thread.Sleep(1000);

    //     Monster monster = new Monster("슬라임");
    //     monster.SetStat(hp: 10, mp: 0, atk: 1, def: 1);
    //     int level = 1;
    //     while(true)
    //     {
    //         switch (level)
    //         {
    //             case 2:
    //                 monster = new Monster("주황버섯");
    //                 monster.SetStat(hp: 20, mp: 0, atk: 5, def: 2);
    //                 break;
    //             //실습.
    //             case 3:
    //                 monster = new Monster("발록");
    //                 monster.SetStat(hp: 100, mp: 100, atk: 50, def: 30);
    //                 break;
    //         }

    //         // 배틀.
    //         while(true)
    //         {
    //             Console.Clear();
    //             Console.WriteLine($"레벨 {level}");

    //             Console.WriteLine(monster.Name);
    //             monster.ShowStat();

    //             Console.WriteLine(_player.Name);
    //             _player.ShowStat();

    //             Console.WriteLine("1.공격하기, 2.도망가기");
    //             string input = InputManager.ReadLine();

    //             if (input == "1")
    //             {
    //                 Console.Clear();
    //                 _player.Attack(monster);
    //                 Thread.Sleep(1000);
    //                 if (monster.HpCur <= 0)
    //                 {
    //                     Console.WriteLine($"{monster.Name}은(는) 쓰러졌다");
    //                     Thread.Sleep(2000);
    //                     break;
    //                 }
    //                 // 실습.
    //                 monster.Attack(_player);
    //                 Thread.Sleep(1000);
    //                 if (_player.HpCur <= 0)
    //                 {
    //                     Console.WriteLine($"{_player.Name}은(는) 쓰러졌다");
    //                     Thread.Sleep(2000);
    //                     break;
    //                 }
    //             }
    //             else
    //             {
    //                 _place = Place.Town;
    //                 return;
    //             }

    //         }

    //         Console.Clear();

    //         // 몬스터를 잡으면.
    //         if (_player.HpCur > 0)
    //         {
    //             if (level == 3)
    //             {
    //                 Console.WriteLine("던전 클리어!");
    //                 Console.Write("마을로 돌아가기");
    //                 Console.ReadLine();
    //                 _place = Place.Town;
    //                 return;
    //             }
    //             else
    //             {
    //                 // 간단한 실습.
    //                 Console.WriteLine("레벨 클리어");
    //                 Console.WriteLine("1.다음 단계, 2.마을로 돌아가기");
    //                 string input = InputManager.ReadLine();
    //                 if (input == "1")
    //                 {
    //                     level++;
    //                     continue;
    //                 }
    //                 else
    //                 {
    //                     _place = Place.Town;
    //                     return;
    //                 }
    //             }
    //         }
    //         else
    //         {
    //             // 간단한 실습.
    //             Console.WriteLine("눈앞이 깜깜해졌다..");
    //             Console.Write("마을로 돌아가기");
    //             Console.ReadLine();
    //             _place = Place.Town;
    //             return;
    //         }
    //     }
    // }
}