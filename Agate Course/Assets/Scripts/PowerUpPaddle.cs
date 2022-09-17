using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float kali;
    public GameObject paddlekiri;
    public GameObject paddlekanan;
    private void OnTriggerEnter2D(Collider2D collision)
       
    {
        if (collision == ball)
        {
            paddlekiri.GetComponent<PaddleController>().PowerUpPaddle(kali);
            manager.RemovePowerUp(gameObject);
        }
    }
}
