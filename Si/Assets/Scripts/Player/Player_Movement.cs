using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player_Movement : MonoBehaviour
{

    float hormove = 0;

    float vermove = 0;

    public float runspeedhor = 3;

    public float runspeedver = 3;

    public float runspeed = 0;

    Rigidbody2D rb2d;

    public Joystick joystick;

    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        vermove = joystick.Vertical + runspeedver;
        hormove = joystick.Horizontal + runspeedhor;

        transform.position = new Vector3(hormove, vermove, 0) * Time.deltaTime * runspeed;
    }
}
