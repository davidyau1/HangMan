using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //variables
    public int GuessesLeft;
    public static string word;
<<<<<<< Updated upstream
   static Dictionary<char, int> guessedLetters = new Dictionary<char, int>();
   static Dictionary<char, int> lettersInWord = new Dictionary<char, int>();
=======
    Dictionary<char, int> guessedLetters = new Dictionary<char, int>();
    Dictionary<char, int> lettersInWord = new Dictionary<char, int>();
    static GameState gameState;
    public Text displayWordText;
    public Text guessesLeftText;
    public Text ResultText;
    public Text revealWordText; 
    public Text guessedLetterText;
    public GameObject gameoverScreen;
    public GameObject gameScreen;


>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
        word="";
=======
        word=Words.GetWord();
        revealWordText.text = "The word was " + word;

>>>>>>> Stashed changes
        //changes all letter to caps
        word = word.ToUpper();
        //Set up reveal word on gameover texts
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
<<<<<<< Updated upstream
    public static string DisplayWord()
=======
    public void UpdateGuessCounter()
    {
        guessesLeftText.text = "Guesses Remaining:"+guessesLeft;
    }
    public void DisplayWord()
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
                    displayWord += "_";
=======
                    displayWord += " _";
>>>>>>> Stashed changes
                }
            }
            //this is for multi word and hyphens
            //if not letter 
            else
            {
                if (letter==' ')
                {
                    //just display space 3 times for format
                       displayWord += "   ";

                }
                else
                {
                    //just display non letter
                    displayWord +=letter;
                }
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
<<<<<<< Updated upstream
=======
                        ResultText.text = "You Win";
                        ChangeState(GameState.Win);
                        Debug.Log(gameState);
                        GameOver();
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
                        ResultText.text = "You Lost";

                        Debug.Log(gameState);
                        GameOver();

                    }
                    else
                    {
                        UpdateGuessCounter();
                        guessedLetterText.text += " " + letter;
>>>>>>> Stashed changes
                    }
                    
                }

            }
        }
    }


    public static void StartNewGame()
    {
        //clear any existing game
        guessedLetters.Clear();
<<<<<<< Updated upstream
=======
        guessesLeft = 6;
        guessedLetterText.text = "Letters Guested:";
        ChangeState(GameState.Game);
        UpdateGuessCounter();
>>>>>>> Stashed changes
        lettersInWord.Clear();
        GetWord();
        DisplayWord();
    }


    public void GameOver()
    {
        gameScreen.SetActive(false);
        gameoverScreen.SetActive(true);
    }





    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        
=======
        if (gameState == GameState.Game)
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
>>>>>>> Stashed changes
    }
}
