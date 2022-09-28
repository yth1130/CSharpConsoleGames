// 게임의 플레이어.

class Player
{
    private string number; // 본인이 정한 숫자.
    private string guess; // 상대방 숫자 추측.

    public string Number
    {
        get
        {
            return number;
        }
        set
        {
            number = value;
        }
    }
    public string Guess
    {
        get => guess;
        set => guess = value;
    }


}