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
    public void ClickStart()
    {
        //hide menu show game

        //begins game
        GameManager.StartNewGame();
    }
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
        //hide pause

        //show game
    }


    //extra
    //public void ClickOptions()
    //{

    //}
}
