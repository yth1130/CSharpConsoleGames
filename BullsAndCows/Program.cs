// H. int형으로 표현한 turnType을 enum TurnType을 만들어 TurnType.Human, TurnType.Ai으로 표현하기.
// H. MainGame클래스에 컴퓨터의 랜덤숫자 세개를 뽑는 메서드(이름: GetFullRandomNumber)를 만들고, playerAi의 Number와 Guess에 이 메서드의 리턴값을 할당.
// H. MainGame.Play()를 여러번 플레이하게 수정.
// H. MainGame 클래스에 bool 형식을 반환하는 Continue 메서드를 추가하고 해당 값이 false이면 게임 종료하기.

internal class Program
{
    private static void Main(string[] args)
    {
        MainGame mainGame = new MainGame();
        while (true)
        {
            mainGame.Play();

            if (mainGame.Continue() == false)
            {
                break;
            }
        }
    }
}