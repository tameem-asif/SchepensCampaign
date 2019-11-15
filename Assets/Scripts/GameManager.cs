using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
    private static int currentLevel = 0;
    public static float lives = 3;
    
    public static void moveToNextLevel ()
    {
        switch(currentLevel)
        {
            case 1:
                SceneManager.LoadScene("Level2");
                break;
            
            case 2:
                SceneManager.LoadScene("Level3");
                break;

            case 3:
                SceneManager.LoadScene("Level4");
                break;

            case 4:
                SceneManager.LoadScene("EndMenu");
                break;
        }

        currentLevel++;
    }
    
    
    
    
    //this is for the button in the start menu
    public void loadGame ()
    {
        SceneManager.LoadScene("Level1");
        currentLevel = 1;
    }

    //this is for the button in the end menu to return to start menu
    public void restartGame ()
    {
        SceneManager.LoadScene("StartMenu");
        currentLevel = 0;
    }
    
    //this is to exit the game with the exit button in the end menu
    public void exitGame ()
    {
        Application.Quit();
    }

    
}
