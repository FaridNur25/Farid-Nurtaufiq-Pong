using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("Credit Scene");
    }

    public void Exit()
    {
        Application.Quit();
    }


}
