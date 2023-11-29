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
        computerChoice = (HandShape)Random.Range(0, 3); // �������� ��ǻ���� ������ ����

        DetermineWinner();
    }

    private void DetermineWinner()
    {
        if (playerChoice == computerChoice)
        {
            resultText.text = "���º�!";
        }
        else if ((playerChoice == HandShape.Rock && computerChoice == HandShape.Scissors) ||
                 (playerChoice == HandShape.Paper && computerChoice == HandShape.Rock) ||
                 (playerChoice == HandShape.Scissors && computerChoice == HandShape.Paper))
        {
            resultText.text = "�¸�!";
        }
        else
        {
            resultText.text = "�й�!";
        }
    }
}