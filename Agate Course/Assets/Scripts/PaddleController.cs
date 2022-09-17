using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //input speed
    public float speed;
    //input atas bawah
    public KeyCode Upkey;
    public KeyCode downkey;
    //rigbody
    private Rigidbody2D rig;
   
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = Vector2.zero;
        // getinput
        if (Input.GetKey(Upkey))
        {
            movement = Vector2.up * speed;
        }
        else if (Input.GetKey(downkey))
        {
            movement = Vector2.down * speed;
        }
        rig.velocity = movement;
    }
    public void PowerUpPaddle(float kali)

    {
        speed *= kali;
    }
}
