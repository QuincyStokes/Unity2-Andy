using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuessTheNumberScript : MonoBehaviour
{
    public int smallestNumber = 0;
    public int largestNumber = 99;
    public TextMeshProUGUI hintsText;
    public TextMeshProUGUI guessText;

    private int currentNumber;

    private int numberOfGuesses;
    private int score;

    void Start()
    {
        currentNumber = GenerateRandomNumber();
        GenerateHints(currentNumber);
        numberOfGuesses = 0;
        score = 0;
    }

    public void ShowGameEnd()
    {
        guessText.text = "Game Over";
        hintsText.text = "";
        hintsText.text += "\n" + "Total Guesses: " + numberOfGuesses.ToString() + "\n";
        hintsText.text += "\n" + "Number of Correct Guesses: " + score.ToString() + "\n";
    }

    public int GenerateRandomNumber()
    {
        return Random.Range(smallestNumber, largestNumber+1);
    }

    public void CheckGuess(string guess)
    {
        numberOfGuesses++;
        guessText.text = "You guessed " + guess + "\n";
        
        int newGuess = int.Parse(guess);
        if(newGuess == currentNumber)
        {
            score++;
            guessText.text = "Correct!";
            currentNumber = GenerateRandomNumber();
            GenerateHints(currentNumber);
        }
        else
        {
            //here is where they're wrong
            if(newGuess > currentNumber)
            {
                guessText.text = "Your guess is too big";
            }
            else
            {
                guessText.text = "Your guess is too small";
            }
        }
    }

    public void GenerateHints(int chosenNumber)
    {
        string hints = "";

        // LESSON 3-1: Add code below.
        if(chosenNumber % 2 == 0)
        {
            hints += "The number is even.\n";
        }
        else
        {
            hints += "The number is odd.\n";
        }

        if(chosenNumber >= 50)
        {
            hints += "Your number is >= 50.\n";
        }
        else
        {
            hints += "Your number is < 50\n";
        }

        if(chosenNumber %5 == 0)
        {
            hints += "Your number is a multiple of 5.\n";
        }


        hintsText.text = hints;
    }

    
}
