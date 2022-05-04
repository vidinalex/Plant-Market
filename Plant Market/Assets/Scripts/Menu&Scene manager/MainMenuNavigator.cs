using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNavigator : MonoBehaviour
{
    public void NewGame()
    {
        Debug.Log("Creating new game");

        SceneManager.LoadScene(1);
    }

    public void Continue()
    {
        Debug.Log("Trying to continue game");
    }

    public void Settings()
    {
        Debug.Log("Go to settings");
    }

    public void Exit()
    {
        Debug.Log("Exiting game");

        Application.Quit();
    }
}
