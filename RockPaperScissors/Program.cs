// H1. aiNumber를 userSelect처럼 표현하기.
// H2. 함수 PrintSelectType의 파라미터를 int에서 userSelect로 바꾸고 switch의 case문도 바꾸기. 게임 최종 결과 출력부분 참고.
// H3. 함수 Judge의 파라미터를 int에서 userSelect로 바꾸고 case문도 바꾸기.
// H4. 게임을 여러번 플레이 할 수 있게 바꾸기. q를 누르면 게임 종료.
// H5. 게임을 종료했을 때 플레이어의 승률을 출력하기.

Console.Clear();
// Console.WriteLine("가위 바위 보 게임~");
Console.WriteLine("가위 바위 보 중에 선택해 주세요.");
Console.WriteLine("1.바위 2.보자기 3.가위");
string input = Console.ReadLine();
int userNumber = int.Parse(input);
SelectType userSelect = (SelectType)userNumber;

Random rand = new Random();
int aiNumber = rand.Next(0, 3) + 1; // 0, 1, 2 => 1, 2, 3
// H1.
// SelectType aiSelect = (SelectType)aiNumber;

Console.WriteLine($"유저 : {PrintSelectType(userNumber)}");
Console.WriteLine($"컴퓨터 : {PrintSelectType(aiNumber)}");

JudgeResult result = Judge(userNumber, aiNumber);
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

// H2.
string PrintSelectType(int number)
{
    switch (number)
    {
        case 1:
            return "바위";
        case 2:
            return "보자기";
        case 3:
            return "가위";
    }
    return string.Empty;
}

// H3.
JudgeResult Judge(int a, int b)
{
    switch (a)
    {
        case 1:
        {
            switch (b)
            {
                case 1:   return JudgeResult.Draw;
                case 2:   return JudgeResult.Lose;
                case 3:   return JudgeResult.Win;
            }
            break;
        }
        case 2:
        {
            switch (b)
            {
                case 1:   return JudgeResult.Win;
                case 2:   return JudgeResult.Draw;
                case 3:   return JudgeResult.Lose;
            }
            break;
        }
        case 3:
        {
            switch (b)
            {
                case 1:   return JudgeResult.Lose;
                case 2:   return JudgeResult.Win;
                case 3:   return JudgeResult.Draw;
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







// Console.Clear();
// Console.WriteLine("가위 바위 보 게임~");
// Console.WriteLine("가위 바위 보 중에 선택해 주세요.");
// Console.WriteLine("1.바위 2.보자기 3.가위");
// string input = Console.ReadLine();
// int userNumber = int.Parse(input);
// SelectType userSelect = (SelectType)userNumber;

// Random rand = new Random();
// int aiNumber = rand.Next(0, 3) + 1; // 0, 1, 2 => 1, 2, 3
// SelectType aiSelect = (SelectType)aiNumber;

// Console.WriteLine($"유저 : {PrintSelectType(userSelect)}");
// Console.WriteLine($"컴퓨터 : {PrintSelectType(aiSelect)}");

// JudgeResult result = Judge(userSelect, aiSelect);
// switch (result)
// {
//     case JudgeResult.Win: 
//         Console.WriteLine("이겼습니다!");
//         break;
//     case JudgeResult.Lose:
//         Console.WriteLine("졌습니다");
//         break;
//     case JudgeResult.Draw: 
//         Console.WriteLine("비겼습니다");
//         break;
// }


// string PrintSelectType(SelectType type)
// {
//     switch (type)
//     {
//         case SelectType.Rock:
//             return "바위";
//         case SelectType.Paper:
//             return "보자기";
//         case SelectType.Scissors:
//             return "가위";
//     }
//     return string.Empty;
// }

// a입장에서의 결과를 반환.
// JudgeResult Judge(SelectType a, SelectType b)
// {
//     switch (a)
//     {
//         case SelectType.Rock:
//         {
//             switch (b)
//             {
//                 case SelectType.Rock:       return JudgeResult.Draw;
//                 case SelectType.Paper:      return JudgeResult.Lose;
//                 case SelectType.Scissors:   return JudgeResult.Win;
//             }
//             break;
//         }
//         case SelectType.Paper:
//         {
//             switch (b)
//             {
//                 case SelectType.Rock:       return JudgeResult.Win;
//                 case SelectType.Paper:      return JudgeResult.Draw;
//                 case SelectType.Scissors:   return JudgeResult.Lose;
//             }
//             break;
//         }
//         case SelectType.Scissors:
//         {
//             switch (b)
//             {
//                 case SelectType.Rock:       return JudgeResult.Lose;
//                 case SelectType.Paper:      return JudgeResult.Win;
//                 case SelectType.Scissors:   return JudgeResult.Draw;
//             }
//             break;
//         }
//     }
//     return JudgeResult.Draw;
// }
