Console.Clear();
Console.WriteLine("숫자야구게임!");
Console.WriteLine("숫자를 정해주세요");
string myNumber = Console.ReadLine();
// Console.WriteLine(myNumber);

// int randumNumber = rand.Next(0, 3); // 0, 1, 2
int randomNumber1, randomNumber2, randomNumber3;
randomNumber1 = GetRandomNumber();
randomNumber2 = GetRandomNumber(new int[] { randomNumber1 });
randomNumber3 = GetRandomNumber(new int[] { randomNumber1, randomNumber2 });

string aiNumber = $"{randomNumber1}{randomNumber2}{randomNumber3}";
Console.WriteLine(aiNumber);

string guessNumber;
int strikeCount, ballCount, outCount;
int turnType = 0; // 0: 플레이어, 1: AI
while (true)
{
    if (turnType == 0)
    {
        Console.WriteLine("상대방의 숫자를 추측해주세요");
        guessNumber = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("컴퓨터가 당신의 숫자를 추측하고있습니다.");
        Thread.Sleep(3000);
        randomNumber1 = GetRandomNumber();
        randomNumber2 = GetRandomNumber(new int[] { randomNumber1 });
        randomNumber3 = GetRandomNumber(new int[] { randomNumber1, randomNumber2 });
        guessNumber = $"{randomNumber1}{randomNumber2}{randomNumber3}";
        Console.WriteLine(guessNumber);
    }
    VerifyGuess(aiNumber, guessNumber, out strikeCount, out ballCount, out outCount);
    if (strikeCount == 3)
    {
        Console.WriteLine($"3 스트라이크!");
        break;
    }
    else
    {
        Console.WriteLine($"{strikeCount}스트라이크, {ballCount}볼, {outCount}아웃");
    }
    // Console.WriteLine();
    turnType = (turnType == 0) ? 1 : 0;
}

// Console.WriteLine("게임 종료");
if (turnType == 0)
{
    Console.WriteLine("플레이어 승리!");
}
else
{
    Console.WriteLine("컴퓨터 승리..");
}


void VerifyGuess(string answer, string guess, out int strikeCount, out int ballCount, out int outCount)
{
    int[] answerNumbers = { answer[0] - '0', answer[1] - '0', answer[2] - '0' };
    int[] guessNumbers = { guess[0] - '0', guess[1] - '0', guess[2] - '0' };

    strikeCount = 0;
    ballCount = 0;
    outCount = 0; // out은 키워드라서 사용할 수 없다.
    for (int i = 0; i < 3; i++)
    {
        if (guessNumbers.Contains(answerNumbers[i]))
        {
            if (answerNumbers[i] == guessNumbers[i])
            {
                strikeCount++;
            }
            else
            {
                ballCount++;
            }
        }
        else
        {
            outCount++;
        }
    }
}


int GetRandomNumber(int[] exceptions = null)
{
    Random rand = new Random();
    int result = rand.Next(0, 10);
    // 제외할 숫자가 있을 때,
    // 제외할 숫자에 결과값이 포함될 때.
    while(exceptions != null && exceptions.Contains(result))
    {
        result = rand.Next(0, 10);
    }
    return result;
}