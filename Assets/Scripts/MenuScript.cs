using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    //Button Click Functions
    public void ClickQuit()
    {
        //quit application
        Application.Quit();
    }
<<<<<<< Updated upstream
    public void ClickStart()
    {
        //hide menu show game

        //begins game
        GameManager.StartNewGame();
    }
=======
 
>>>>>>> Stashed changes
    public void ClickMain()
    {
        //hide current screen 

        //show main menu

    }
    public void ClickPause()
    {
        //hide game

        //show pause

    }
    public void ClickUnpause()
    {
<<<<<<< Updated upstream
        //hide pause

        //show game
=======
        GameManager.ChangeState(GameState.Game);

     
>>>>>>> Stashed changes
    }


    //extra
    //public void ClickOptions()
    //{

    //}
}
