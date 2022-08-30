using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text ScoreKiri;
    public Text ScoreKanan;

    public ScoreManager manager;

    private void Update()
    {
        ScoreKiri.text = manager.leftscore.ToString();
        ScoreKanan.text = manager.rightscore.ToString();
    }
}
