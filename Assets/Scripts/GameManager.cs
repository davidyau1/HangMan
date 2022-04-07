using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //variables
    public int GuessesLeft;
    public static string word;
   static Dictionary<char, int> guessedLetters = new Dictionary<char, int>();
   static Dictionary<char, int> lettersInWord = new Dictionary<char, int>();

    public bool CheckSolve()
    {
        //check every value in key
        foreach (var key in lettersInWord)
        {
            //check if letter has been guessed
            if (guessedLetters.ContainsKey(key.Key))
            {

            }
            else
            {
                // at least one letter hasn't been guessed
                return false;
            }
        }
        //if all letters have been guessed return true
        return true;
    }
    public static void GetWord()
    {
        //get word and save it
        word="";
        //changes all letter to caps
        word.ToUpper();
        //loops through word and add letter to dictionary
        foreach (var letter in word)
        {
            //checks char is a letter
            if (Char.IsLetter(letter))
            {

                if (!lettersInWord.ContainsKey(letter))
                {
                    //adds letter to dictionary
                    lettersInWord.Add(letter, 1);

                }
            }
        }

    } 
    public static string DisplayWord()
    {
        //reset string
        string displayWord="";
        //loops through word
        foreach (var letter in word)
        {
            //checks if letter
            if (Char.IsLetter(letter))
            {
                //if letter is guessed show
                if (guessedLetters.ContainsKey(letter))
                {
                    //adds letter to dictionary
                    displayWord+=letter;

                }
                //else us _ as placeholder
                else
                {
                    displayWord += "_";
                }
            }
            //if not letter just display char
            else
            {
                displayWord+=letter;
            }
        }
        return displayWord;
    }
    public void MakeGuess(char letter)
    {
        //changers input into letter
        Char.ToUpper(letter);
        //checks it a letter
        if (Char.IsLetter(letter))
        {
            //checks if been guessed
            if (!guessedLetters.ContainsKey(letter))
            {
                //adds it to guessed letters
                guessedLetters.Add(letter, 1);
                //check if letter is in word
                if (lettersInWord.ContainsKey(letter))
                {
                    //updates display
                    DisplayWord();

                    //if word is solved
                    if (CheckSolve())
                    {
                        //victory
                    }
                }
                //wrong
                else
                {
                    //reduces guessesleft
                    GuessesLeft-=1;
                    if (GuessesLeft <=0)
                    {
                        //loss
                    }
                    
                }

            }
        }
    }


    public static void StartNewGame()
    {
        //clear any existing game
        guessedLetters.Clear();
        lettersInWord.Clear();
        GetWord();
        DisplayWord();
    }








    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
