using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour
{
    //Variables
    public int levelToLoad;                 //Basicly the level to load

    //A function that loads the level wich we spcify above
    public void loadLevel()
    {
        Application.LoadLevel(levelToLoad);
    }

    //A function that cloases the application
    public void closeApp()
    {
        Application.Quit();
    }
}
