class TitleScreen
{
    // // 델리게이트 생성.
    // public delegate void SimpleDelegate();

    // public void Show(SimpleDelegate startAction)
    public void Show(System.Action startAction)
    {
        Console.Clear();
        Console.WriteLine("턴제 RPG 게임");
        Console.WriteLine("1.게임시작");

        // Console.Write(">");
        // string input = Console.ReadLine();

        string input = InputManager.ReadLine();
        // 인게임 진입.
        if (input == "1")
        {
            // Play();
            // _playMethod();
            startAction.Invoke();
        }
    }
}