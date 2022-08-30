using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int leftscore;
    public int rightscore;

    public int maxScore;

    public BallController ball;

    public void AddRightScore(int increment)
    {
        rightscore += increment;
        ball.ResetBall();

        if (rightscore >= maxScore) 
        {
            GameOver();
        }
    }

    public void AddLeftScore(int increment)
    {
        leftscore += increment;
        ball.ResetBall();

        if (leftscore >= maxScore)
        {
            GameOver();
        }
    }


    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
