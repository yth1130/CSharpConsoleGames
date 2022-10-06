class MainGame
{
    enum Place
    {
        None,
        Town,
        Shop,
        Dungeon,
    }

    Place place;
    Player player;
    
    public void ShowTitle()
    {
        Console.Clear();
        Console.WriteLine("턴제 RPG 게임");
        Console.WriteLine("1.게임시작");

        // Console.Write(">");
        // string input = Console.ReadLine();

        string input = InputManager.ReadLine();
        if (input == "1")
        {
            Play();
        }
    }

    // 상점.
    // 던전 : 계속 몬스터들이 나오고 다 잡으면 던전 빠져나오기.
    public void Play()
    {
        place = Place.Town;
        player = new Player(name: "주인공");
        player.SetStat(hp: 100, mp: 100, atk: 5, def: 5);

        while (place != Place.None)
        {
            switch(place)
            {
                case Place.Town: ShowTown(); break;
                case Place.Shop: ShowShop(); break;
                case Place.Dungeon: ShowDungeon(); break;
            }
        }
    }

    public void ShowTown()
    {
        Console.Clear();
        Console.WriteLine("마을");
        Console.WriteLine("1.상점가기, 2.던전가기, 3.스탯보기, 4.게임종료");
        string input = InputManager.ReadLine();

        if (input == "1")
        {
            place = Place.Town;
            return;
        }
        if (input == "2")
        {
            place = Place.Dungeon;
            return;
        }
        if (input == "3")
        {
            Console.Clear();
            player.ShowStat();
            Console.Write("\n돌아가기");
            Console.ReadLine();
            return;
        }
        if (input == "4")
        {
            place = Place.None;
            return;
        }
    }

    public void ShowShop()
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("1.구입, 2.판매, 3.나가기");
            string input = InputManager.ReadLine();

            if (input == "3")
            {
                break;
            }
        }
    }

    public void ShowDungeon()
    {
        Console.Clear();
        Console.WriteLine("던전 입장");
        Thread.Sleep(1000);

        Monster monster = new Monster("슬라임");
        monster.SetStat(hp: 50, mp: 0, atk: 1, def: 1);
        int level = 1;
        while(true)
        {
            switch (level)
            {
                //실습.
                case 2:
                    monster = new Monster("주황버섯");
                    monster.SetStat(hp: 100, mp: 0, atk: 5, def: 2);
                    break;
            }

            // 배틀.
            while(true)
            {
                Console.Clear();
                Console.WriteLine($"레벨 {level}");
                Console.WriteLine(monster.Name);
                Console.WriteLine("HP : [||||||||||||]");
                Console.WriteLine("HP : [||||||||    ]");

                Console.WriteLine("플레이어");
                player.ShowStat();

                Console.WriteLine("1.공격하기, 2.도망가기");
                Console.ReadLine();

                player.Attack(monster);
                Thread.Sleep(1000);
                monster.Attack(player);
                Thread.Sleep(2000);
            }


            // 몬스터를 잡으면.
            level++;
            if (level == 3)
            {
                Console.WriteLine("던전 클리어!");
                Console.Write("마을로 돌아가기");
                Console.ReadLine();
                place = Place.Town;
            }
            else
            {
                Console.WriteLine("레벨 클리어");

            }
        }
    }
}