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
     public void ClickMain()
    {
        //change state to menu
        GameManager.ChangeState(GameState.Menu);
    }
    public void ClickPause()
    {
        //change state to pause
        GameManager.ChangeState(GameState.Pause);

      

    }
    public void ClickUnpause()
    {
        //change state to game (unpause)
        GameManager.ChangeState(GameState.Game);

    }


    //extra
    //public void ClickOptions()
    //{

    //}
}
