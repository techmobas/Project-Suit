using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPSControl : MonoBehaviour
{
    public enum Choices {
        ROCK = 1, 
        PAPER = 2, 
        SCISSORS = 3}

    private int playerInt = -1;
    private int botInt = -1;

    private bool playerTurn = true;
    
    void Update(){
        if (playerTurn && playerInt == -1) return;

        else{
            BotChoose();
        }
    }

    private void CheckWinner(){
        if(playerInt == botInt){
            //DRAW
        }

        else if (playerInt == (int)Choices.ROCK && botInt == (int)Choices.PAPER){
            //LOSE
        }

        else if (playerInt == (int)Choices.ROCK && botInt == (int)Choices.SCISSORS)
        {
            //WIN
        }
        else if (playerInt == (int)Choices.PAPER && botInt == (int)Choices.SCISSORS)
        {
            //LOSE
        }

        else if (playerInt == (int)Choices.PAPER && botInt == (int)Choices.ROCK)
        {
            //WIN
        }
        else if (playerInt == (int)Choices.SCISSORS && botInt == (int)Choices.ROCK)
        {
            //LOSE
        }

        else if (playerInt == (int)Choices.SCISSORS && botInt == (int)Choices.PAPER)
        {
            //WIN
        }
    }

    public int PlayerInt(){
        return playerInt;
    }

    public void PlayerChoose(){
        PlayerInt();
        playerTurn = false;
    }

    public void BotChoose(){
        botInt = Random.Range(1, 3);
    }
}
