using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class RpsScene : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _rockButton;
    [SerializeField] private Button _paperButton;
    [SerializeField] private Button _scissorsButton;

    [SerializeField] private GameObject _playerRock;
    [SerializeField] private GameObject _playerPaper;
    [SerializeField] private GameObject _playerScissors;
    
    [SerializeField] private GameObject _aiRock;
    [SerializeField] private GameObject _aiPaper;
    [SerializeField] private GameObject _aiScissors;
    
    int _countTotalGame = 0;
    int _countWinGame = 0;

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
    
    void Start()
    {
        _startButton.onClick.AddListener(() => StartGame());
        _rockButton.onClick.AddListener(() => Click(SelectType.Rock));
        _paperButton.onClick.AddListener(() => Click(SelectType.Paper));
        _scissorsButton.onClick.AddListener(() => Click(SelectType.Scissors));

        StartGame();
    }

    // void Update()
    // {
        
    // }

    void StartGame()
    {
        print("가위바위보 게임~");
        print("바위, 보자기, 가위 중에 선택해주세요");
        // print("1.바위 2.보자기 3.가위");
        // string input = Console.ReadLine();
        // int userNumber = int.Parse(input);

        _playerRock.SetActive(true);
        _playerPaper.SetActive(false);
        _playerScissors.SetActive(false);

        _aiRock.SetActive(true);
        _aiPaper.SetActive(false);
        _aiScissors.SetActive(false);
    }

    void Click(SelectType userSelect)
    {
        StartCoroutine(GameRoutine(userSelect));
    }

    IEnumerator GameRoutine(SelectType userSelect)
    {
        print("가위~");
        // Thread.Sleep(1000);
        yield return new WaitForSeconds(1f);
        print("바위~");
        // Thread.Sleep(1000);
        yield return new WaitForSeconds(1f);
        print("보~");
        
        // Random rand = new Random();
        // int aiNumber = rand.Next(1, 4);
        int aiNumber = Random.Range(1, 4);
        //---------------------------------------------
        // H1.
        SelectType aiSelect = (SelectType)aiNumber;
        //---------------------------------------------

        // Console.WriteLine($"유저의 입력: {userNumber}");
        // Console.WriteLine($"유저의 입력: {PrintSelectType(userNumber)}");
        // print($"유저의 입력: {PrintSelectType2(userSelect)}");
        // print($"컴퓨터의 입력: {PrintSelectType2(aiSelect)}");

        _playerRock.SetActive(false);
        switch (userSelect)
        {
            case SelectType.Rock: _playerRock.SetActive(true); break;
            case SelectType.Paper: _playerPaper.SetActive(true); break;
            case SelectType.Scissors: _playerScissors.SetActive(true); break;
        }

        _aiRock.SetActive(false);
        switch (aiSelect)
        {
            case SelectType.Rock: _aiRock.SetActive(true); break;
            case SelectType.Paper: _aiPaper.SetActive(true); break;
            case SelectType.Scissors: _aiScissors.SetActive(true); break;
        }

        // Thread.Sleep(1000);
        yield return new WaitForSeconds(1f);

        // JudgeResult result = Judge(userNumber, aiNumber);
        JudgeResult result = Judge(userSelect, aiSelect);
        switch (result)
        {
            case JudgeResult.Win:
            {
                print("이겼습니다!");
                // countWinGame++;
                break;
            }
            case JudgeResult.Lose:
            {
                print("졌습니다");
                break;
            }
            case JudgeResult.Draw:
            {
                print("비겼습니다");
                break;
            }
        }

        // Console.WriteLine("게임을 계속하시겠습니까?(y/n)");
        // input = Console.ReadLine();
        // if (input == "n")
        // {
        //     // 1 / 5 => 0.2 => 0
        //     // (float)1.0 / (float)5.0 => 0.2
        //     float winningRate = ((float)countWinGame / countTotalGame) * 100f;
        //     Console.WriteLine($"승률 : {winningRate}%");
        //     break;
        // }
    }

    JudgeResult Judge(SelectType a, SelectType b)
    {
        switch(a)
        {
            case SelectType.Rock: //a가 바위를 냄.
            {
                switch (b)
                {
                    case SelectType.Rock: // b가 바위를 냄.
                        return JudgeResult.Draw;
                    case SelectType.Paper: // b가 보자기를 냄.
                        return JudgeResult.Lose;
                    case SelectType.Scissors: // b가 가위를 냄.
                        return JudgeResult.Win;
                }
                break;
            }
            case SelectType.Paper: // a가 보자기를 냄.
            {
                switch (b)
                {
                    case SelectType.Rock: // b가 바위를 냄.
                        return JudgeResult.Win;
                    case SelectType.Paper: // b가 보자기를 냄.
                        return JudgeResult.Draw;
                    case SelectType.Scissors: // b가 가위를 냄.
                        return JudgeResult.Lose;
                }
                break;
            }
            case SelectType.Scissors: // a가 가위를 냄.
            {
                switch (b)
                {
                    case SelectType.Rock: // b가 바위를 냄.
                        return JudgeResult.Lose;
                    case SelectType.Paper: // b가 보자기를 냄.
                        return JudgeResult.Win;
                    case SelectType.Scissors: // b가 가위를 냄.
                        return JudgeResult.Draw;
                }
                break;
            }
        }
        return JudgeResult.Draw;
    }

    string PrintSelectType2(SelectType type)
    {
        switch(type)
        {
            case SelectType.Rock:
                return "바위";
            case SelectType.Scissors:
                return "가위";
            case SelectType.Paper:
                return "보자기";
        }
        return string.Empty;
    }
}
