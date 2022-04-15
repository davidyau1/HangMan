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
    Pause,
    GameOver
}

public class GameManager : MonoBehaviour
{
    
  
    //variables
    public int guessesLeft;
    public static string word;
    HashSet<char> guessedLetters = new HashSet<char>();
    HashSet<char> lettersInWord = new HashSet<char>();
    static GameState gameState;
    public Text displayWordText;
    public Text guessesLeftText;
    public Text resultText;
    public Text revealWord;
    public Text lettersGuessedWrong;
    public GameObject gameOverScreen;
    public GameObject gameScreen;



    public bool CheckSolve()
    {
        //check every value in key
        foreach (var letter in lettersInWord)
        {
            //check if letter has been guessed
            if (guessedLetters.Contains(letter))
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
        revealWord.text="The word was "+word;
        word=word.ToUpper();
        //loops through word and add letter to dictionary
        foreach (var letter in word)
        {
            //checks char is a letter
            if (Char.IsLetter(letter))
            {

                if (!lettersInWord.Contains(letter))
                {
                    //adds letter to dictionary
                    lettersInWord.Add(letter);

                }
            }
        }

    } 
    public void UpdateGuessCounter()
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
                if (guessedLetters.Contains(letter))
                {
                    //adds letter to dictionary
                    displayWord+=letter;

                }
                //else us _ as placeholder
                else
                {
                    displayWord += "_ ";
                }
            }
            //if not letter just display char and if space display as 3 spaces
            else
            {
                if (letter==' ')
                {
                    displayWord += "   ";
                }
                else
                {
                    displayWord += letter;

                }
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
            if (!guessedLetters.Contains(letter))
            {
                //adds it to guessed letters
                guessedLetters.Add(letter);
                //check if letter is in word
                if (lettersInWord.Contains(letter))
                {
                    //updates display
                    DisplayWord();

                    //if word is solved
                    if (CheckSolve())
                    {
                        resultText.text = "You Win";
                        GameOver();
                        

                    }
                }
                //wrong
                else
                {
                    //reduces guessesleft
                    guessesLeft -= 1;
                    if (guessesLeft <= 0)
                    {
                        resultText.text = "You Lose";
                        GameOver();


                    }
                    else
                    {
                        lettersGuessedWrong.text += " " + letter;
                        UpdateGuessCounter();
                    }
                    
                }

            }
        }
    }

   public void GameOver()
    {
        ChangeState(GameState.GameOver);
        gameScreen.SetActive(false);
        gameOverScreen.SetActive(true);
        Debug.Log(gameState);

    }
    public void StartNewGame()
    {
        //clear any existing game
        ChangeState(GameState.Game);
        lettersGuessedWrong.text = "";
        guessedLetters.Clear();
        guessesLeft = 6;
        UpdateGuessCounter();
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
        if (gameState==GameState.Game)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                MakeGuess('A');
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                MakeGuess('B');
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                MakeGuess('C');
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                MakeGuess('D');
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                MakeGuess('E');
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                MakeGuess('F');
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                MakeGuess('G');
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                MakeGuess('H');
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                MakeGuess('I');
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                MakeGuess('J');
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                MakeGuess('K');
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                MakeGuess('L');
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                MakeGuess('M');
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                MakeGuess('N');
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                MakeGuess('O');
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                MakeGuess('P');
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                MakeGuess('Q');
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                MakeGuess('R');
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                MakeGuess('S');
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                MakeGuess('T');
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                MakeGuess('U');
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                MakeGuess('V');
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                MakeGuess('W');
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                MakeGuess('X');
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                MakeGuess('Y');
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                MakeGuess('Z');
            }
        }
        
    }
}
