using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RPSControl : MonoBehaviour
{
    public enum Choices {
        ROCK = 1, 
        PAPER, 
        SCISSORS}

    private int playerInt = -1;
    private int botInt = -1;

    private bool playerTurn = true;

    [SerializeField] private TextMeshProUGUI playerText;
    [SerializeField] private TextMeshProUGUI botText;
    [SerializeField] private TextMeshProUGUI resultText;

    private void Start()
    {
    }

    private void Update(){
        ChangeText();

        if (playerTurn && playerInt == -1) return;

        else{
            BotChoose();
            CheckWinner();
            playerInt = -1;
            playerTurn = true;
        }
    }

    private void ChangeText()
    {
        if (playerInt == (int)Choices.ROCK)
        {
            playerText.text = "ROCK";
        }

        else if (playerInt == (int)Choices.PAPER)
        {
            playerText.text = "PAPER";
        }

        else if (playerInt == (int)Choices.SCISSORS)
        {
            playerText.text = "SCISSORS";
        }
    }

    private void CheckWinner(){
        if(playerInt == botInt){
            //D
            resultText.text = "DRAW";
        }

        else if (playerInt == (int)Choices.ROCK && botInt == (int)Choices.PAPER){
            resultText.text = "LOSE";
        }

        else if (playerInt == (int)Choices.ROCK && botInt == (int)Choices.SCISSORS)
        {
            //WIN
            resultText.text = "WIN";
        }
        else if (playerInt == (int)Choices.PAPER && botInt == (int)Choices.SCISSORS)
        {
            //LOSE
            resultText.text = "LOSE";
        }

        else if (playerInt == (int)Choices.PAPER && botInt == (int)Choices.ROCK)
        {
            //WIN
            resultText.text = "WIN";
        }
        else if (playerInt == (int)Choices.SCISSORS && botInt == (int)Choices.ROCK)
        {
            //LOSE
            resultText.text = "LOSE";
        }

        else if (playerInt == (int)Choices.SCISSORS && botInt == (int)Choices.PAPER)
        {
            //WIN
            resultText.text = "WIN";
        }
    }

    public void PlayerChoose(int choose){
        playerInt = choose;
        playerTurn = false;
    }

    public void BotChoose(){
        botInt = Random.Range(1, 3);

        if (botInt == (int)Choices.ROCK)
        {
            botText.text = "ROCK";
        }

        else if (botInt == (int)Choices.PAPER)
        {
            botText.text = "PAPER";
        }

        else if (botInt == (int)Choices.SCISSORS)
        {
            botText.text = "SCISSORS";
        }
    }
}
