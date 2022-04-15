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
        GameManager.ChangeState(GameState.Menu);
    }
    public void ClickPause()
    {
        GameManager.ChangeState(GameState.Pause);

      

    }
    public void ClickUnpause()
    {
        GameManager.ChangeState(GameState.Game);

    }


    //extra
    //public void ClickOptions()
    //{

    //}
}
