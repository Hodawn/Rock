using UnityEngine;
using UnityEngine.UI;

public class RockPaperScissorsGame : MonoBehaviour
{
    public Text resultText;
    public Image computerHandImage; // 추가된 부분
    public Image computer;

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


        switch (computerChoice)
        {
            case HandShape.Rock:
                computerHandImage.sprite = Resources.Load<Sprite>("R"); // 리소스 폴더에 있는 이미지 이름
                break;
            case HandShape.Paper:
                computerHandImage.sprite = Resources.Load<Sprite>("P");
                break;
            case HandShape.Scissors:
                computerHandImage.sprite = Resources.Load<Sprite>("S");
                break;
        }


        DetermineWinner();
    }

    private void DetermineWinner()
    {
        if (playerChoice == computerChoice)
        {
            resultText.text = "Draw";
            computer.sprite = Resources.Load<Sprite>("Ori_000");
        }
        else if ((playerChoice == HandShape.Rock && computerChoice == HandShape.Scissors) ||
                 (playerChoice == HandShape.Paper && computerChoice == HandShape.Rock) ||
                 (playerChoice == HandShape.Scissors && computerChoice == HandShape.Paper))
        {
            resultText.text = "Win";
            computer.sprite = Resources.Load<Sprite>("Ori_001");
        }
        else
        {
            resultText.text = "Lose";
            computer.sprite = Resources.Load<Sprite>("Ori_002");
        }
    }
}