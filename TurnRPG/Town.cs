class Town : Placement
{

    public System.Action GoToDungeonAction;
    public System.Action ExitGameAction;
    
    public Town(string name) : base(name)
    {
    }

    public override void ShowInterface()
    {
        Console.Clear();
        Console.WriteLine("마을");
        Console.WriteLine("1.상점가기, 2.던전가기, 3.스탯보기, 4.게임종료");
        string input = InputManager.ReadLine();
        if (input == "1")
        {
            ShowShop();
            return;
        }
        if (input == "2")
        {
            GoToDungeonAction?.Invoke();
            return;
        }
        if (input == "3")
        {
            Console.Clear();
            _player.ShowStat();
            Console.Write("\n돌아가기");
            Console.ReadLine();
            return;
        }
        if (input == "4")
        {
            ExitGameAction?.Invoke();
            return;
        }
    }

    void ShowShop()
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("상점");
            Console.WriteLine("1.구입, 2.판매, 3.나가기");
            string input = InputManager.ReadLine();

            if (input == "3")
            {
                // _place = Place.Town;
                break;
            }
        }
    }

    // public override void ProcessInput(string input)
    // {
    //     AdditionalProcessInputHandler.Invoke(input);
    // }
}