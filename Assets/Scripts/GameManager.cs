using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//states possible in game
public enum GameState
{
    Menu,
    Game,
    Win,
    Loss,
    Pause
}

public class GameManager : MonoBehaviour
{
    
  
    //variables
    public int guessesLeft;
    public static string word;
    Dictionary<char, int> guessedLetters = new Dictionary<char, int>();
    Dictionary<char, int> lettersInWord = new Dictionary<char, int>();
    static GameState gameState;
    public Text displayWordText;
    public Text guessesLeftText;



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
    public void GetWord()
    {
        //get word and save it
        word=Words.GetWord();
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
    public void UdpdateGuessCounter()
    {
        guessesLeftText.text = "Guesses Remaining:"+guessesLeft;
    }
    public void DisplayWord()
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
                    displayWord += "-";
                }
            }
            //if not letter just display char
            else
            {
                displayWord+=letter;
            }
        }
        displayWordText.text= displayWord;
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
                        ChangeState(GameState.Win);
                        Debug.Log(gameState);
                        //victory
                    }
                }
                //wrong
                else
                {
                    //reduces guessesleft
                    guessesLeft -= 1;
                    if (guessesLeft <= 0)
                    {
                        ChangeState(GameState.Loss);
                        //loss
                        Debug.Log(gameState);

                    }
                    else
                    {
                        UdpdateGuessCounter();
                    }
                    
                }

            }
        }
    }


    public void StartNewGame()
    {
        //clear any existing game
        guessedLetters.Clear();
        guessesLeft = 6;
        UdpdateGuessCounter();
        lettersInWord.Clear();
        GetWord();
        Debug.Log(word);
        DisplayWord();
    }






    public static void ChangeState(GameState newState)
    {
        gameState = newState;
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MakeGuess('a');
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            MakeGuess('b');
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            MakeGuess('c');
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            MakeGuess('d');
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            MakeGuess('e');
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            MakeGuess('f');
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            MakeGuess('g');
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            MakeGuess('h');
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            MakeGuess('i');
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            MakeGuess('j');
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            MakeGuess('k');
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            MakeGuess('l');
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            MakeGuess('m');
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            MakeGuess('n');
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            MakeGuess('o');
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            MakeGuess('p');
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            MakeGuess('q');
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            MakeGuess('r');
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MakeGuess('s');
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            MakeGuess('t');
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            MakeGuess('u');
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            MakeGuess('v');
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            MakeGuess('w');
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            MakeGuess('x');
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            MakeGuess('y');
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            MakeGuess('z');
        }
    }
}
