class MainGame
{
    private Player playerHuman;
    private Player playerAi;

    public MainGame()
    {
        playerHuman = new Player();
        playerAi = new Player();
    }

    public void Play()
    {
        Console.Clear();
        Console.WriteLine("숫자야구게임!");
        Console.WriteLine("숫자를 정해주세요");

        // 입력 받아서 playerHuman.Number에 넣기.
        playerHuman.Number = Console.ReadLine();
        while (CheckInputValidation(playerHuman.Number) == false)
        {
            playerHuman.Number = Console.ReadLine();
        }

        int randomNumber1, randomNumber2, randomNumber3;
        randomNumber1 = GetRandomNumber();
        randomNumber2 = GetRandomNumber(new int[] { randomNumber1 });
        randomNumber3 = GetRandomNumber(new int[] { randomNumber1, randomNumber2 });

        playerAi.Number = $"{randomNumber1}{randomNumber2}{randomNumber3}";
        // playerAi.Number = GetFullRandomNumber();
        Console.WriteLine(playerAi.Number);

        string guessNumber;
        int countStrike, countBall, countOut;
        int turnType = 0; // 0: 사람, 1: AI
        Player playerOffense, playerDefender;

        // 1.상대방의 숫자를 추측하기.
        // 2.추측한 숫자와 상대방의 숫자를 비교하고 결과 알려주기.
        // 3.추측한 숫자가 정확히 일치하면 게임 종료.
        while (true)
        {
            if (turnType == 0)
            {
                playerOffense = playerHuman;
                playerDefender = playerAi;

                Console.WriteLine("상대방의 숫자를 추측해주세요");
                playerOffense.Guess = Console.ReadLine();
                // 실습.
                while (CheckInputValidation(playerOffense.Guess) == false)
                {
                    playerOffense.Guess = Console.ReadLine();
                }
            }
            else
            {
                playerOffense = playerAi;
                playerDefender = playerHuman;

                Console.WriteLine("컴퓨터가 당신의 숫자를 추측하고있습니다.");
                Thread.Sleep(3000);
                // 실습.
                randomNumber1 = GetRandomNumber();
                randomNumber2 = GetRandomNumber(new int[] { randomNumber1 });
                randomNumber3 = GetRandomNumber(new int[] { randomNumber1, randomNumber2 });
                playerOffense.Guess = $"{randomNumber1}{randomNumber2}{randomNumber3}";
                // playerOffense.Guess = GetFullRandomNumber();
                Console.WriteLine(playerOffense.Guess);
            }
            VerifyGuess(playerDefender.Number, playerOffense.Guess, out countStrike, out countBall, out countOut);
            
            if (countStrike == 3)
            {
                Console.WriteLine($"3 스트라이크!");
                break;
            }
            else
            {
                Console.WriteLine($"{countStrike}스트라이크, {countBall}볼, {countOut}아웃");
            }
            // Console.WriteLine();
            turnType = (turnType == 0) ? 1 : 0;
        }

        if (turnType == 0)
        {
            Console.WriteLine("플레이어 승리!");
        }
        else
        {
            Console.WriteLine("컴퓨터 승리..");
        }
    }

    public bool Continue()
    {
        Console.WriteLine("계속 하시겠습니까?(y/n)");
        string input = Console.ReadLine();
        return (input != "n");
    }

    // 정답 확인.
    void VerifyGuess(string answer, string guess, out int countStrike, out int countBall, out int countOut)
    {
        countStrike = 0;
        countBall = 0;
        countOut = 0;
        for (int i = 0; i < 3; i++)
        {
            // 정답에 추측한 숫자가 들어갈 때.
            if (answer.Contains(guess[i]))
            {
                // 자리까지 맞았을 때.
                if (guess[i] == answer[i])
                {
                    countStrike++;
                }
                else
                {
                    countBall++;
                }
            }
            // 정답에 존재하지 않을 때.
            else
            {
                countOut++;
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

    string GetFullRandomNumber()
    {
        int randomNumber1, randomNumber2, randomNumber3;
        randomNumber1 = GetRandomNumber();
        randomNumber2 = GetRandomNumber(new int[] { randomNumber1 });
        randomNumber3 = GetRandomNumber(new int[] { randomNumber1, randomNumber2 });
        return $"{randomNumber1}{randomNumber2}{randomNumber3}";
    }

    // 입력이 숫자이고, 세자리이고, 각 자리의 숫자가 다 다르면 true 리턴.
    // 그 외에는 false 리턴.
    bool CheckInputValidation(string input)
    {
        int inputNumber;
        if (int.TryParse(input, out inputNumber) == false)
        {
            Console.WriteLine("숫자를 입력해주세요");
            return false;
        }
        if (input.Length != 3)
        {
            Console.WriteLine("세자리로 입력해주세요");
            return false;
        }
        // ex) 483이면,
        // 4 => 483 / 100 = 4
        // 8 => 483 - 400 = 83, 83 / 10 = 8
        // 3 => 483 - 400 - 80 = 3
        int digit1st = inputNumber / 100;
        int digit2nd = (inputNumber - digit1st * 100) / 10;
        int digit3rd = (inputNumber - digit1st * 100 - digit2nd * 10);
        if (digit1st == digit2nd || digit1st == digit3rd || digit2nd == digit3rd)
        {
            Console.WriteLine("같은 숫자가 없게 입력해주세요");
            return false;
        }
        return true;
    }
}

