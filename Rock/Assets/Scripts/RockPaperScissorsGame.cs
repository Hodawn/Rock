using UnityEngine;
using UnityEngine.UI;

public class RockPaperScissorsGame : MonoBehaviour
{
    public Text resultText;

    private enum HandShape { Rock, Paper, Scissors };
    private HandShape playerChoice;
    private HandShape computerChoice;

    public void PlayerChoiceRock()
    {
        MakePlayerChoice(HandShape.Rock);
    }

    public void PlayerChoicePaper()
    {
        MakePlayerChoice(HandShape.Paper);
    }

    public void PlayerChoiceScissors()
    {
        MakePlayerChoice(HandShape.Scissors);
    }

    private void MakePlayerChoice(HandShape choice)
    {
        playerChoice = choice;
        computerChoice = (HandShape)Random.Range(0, 3); // 무작위로 컴퓨터의 선택을 생성

        DetermineWinner();
    }

    private void DetermineWinner()
    {
        if (playerChoice == computerChoice)
        {
            resultText.text = "무승부!";
        }
        else if ((playerChoice == HandShape.Rock && computerChoice == HandShape.Scissors) ||
                 (playerChoice == HandShape.Paper && computerChoice == HandShape.Rock) ||
                 (playerChoice == HandShape.Scissors && computerChoice == HandShape.Paper))
        {
            resultText.text = "승리!";
        }
        else
        {
            resultText.text = "패배!";
        }
    }
}