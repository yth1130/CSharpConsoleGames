Console.Clear();
Console.WriteLine("가위 바위 보 중에 선택해 주세요.");
Console.WriteLine("1.바위 2.보자기 3.가위");
string input = Console.ReadLine();
int userNumber = int.Parse(input);
SelectType userSelect = (SelectType)userNumber;

Random rand = new Random();
int aiNumber = rand.Next(0, 3) + 1; // 0, 1, 2 => 1, 2, 3
SelectType aiSelect = (SelectType)aiNumber;

Console.WriteLine($"유저 : {PrintSelectType(userSelect)}");
Console.WriteLine($"컴퓨터 : {PrintSelectType(aiSelect)}");

JudgeResult result = Judge(userSelect, aiSelect);
switch (result)
{
    case JudgeResult.Win: 
        Console.WriteLine("이겼습니다!");
        break;
    case JudgeResult.Lose:
        Console.WriteLine("졌습니다");
        break;
    case JudgeResult.Draw: 
        Console.WriteLine("비겼습니다");
        break;
}

// void Judge()
// {

// }

string PrintSelectType(SelectType type)
{
    switch (type)
    {
        case SelectType.Rock:
            return "바위";
        case SelectType.Paper:
            return "보자기";
        case SelectType.Scissors:
            return "가위";
    }
    return string.Empty;
}

// a입장에서의 결과를 반환.
JudgeResult Judge(SelectType a, SelectType b)
{
    switch (a)
    {
        case SelectType.Rock:
        {
            switch (b)
            {
                case SelectType.Rock:       return JudgeResult.Draw;
                case SelectType.Paper:      return JudgeResult.Lose;
                case SelectType.Scissors:   return JudgeResult.Win;
            }
            break;
        }
        case SelectType.Paper:
        {
            switch (b)
            {
                case SelectType.Rock:       return JudgeResult.Win;
                case SelectType.Paper:      return JudgeResult.Draw;
                case SelectType.Scissors:   return JudgeResult.Lose;
            }
            break;
        }
        case SelectType.Scissors:
        {
            switch (b)
            {
                case SelectType.Rock:       return JudgeResult.Lose;
                case SelectType.Paper:      return JudgeResult.Win;
                case SelectType.Scissors:   return JudgeResult.Draw;
            }
            break;
        }
    }
    return JudgeResult.Draw;
}

enum JudgeResult
{
    Win,
    Lose,
    Draw,
}

enum SelectType
{
    Rock = 1,
    Paper,
    Scissors,
}