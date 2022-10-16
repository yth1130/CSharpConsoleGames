abstract class Placement
{
    private string _name;
    protected Player _player;

    // // 인풋 처리가 끝나지 않았을 때 추가적인 처리 방법.
    // public System.Action<string> AdditionalProcessInputHandler { get; set; } // 자동 구현 프로퍼티.

    public Placement(string name)
    {
        _name = name;
    }

    public void Enter(Player player)
    {
        _player = player;
        Console.Clear();
        Console.WriteLine($"{_name}에 입장");
        Thread.Sleep(1000);
    }

    public abstract void ShowInterface();
    // public abstract void ProcessInput(string input);
}