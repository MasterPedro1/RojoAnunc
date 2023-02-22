using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyJoystick;


public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Joystick joystick;
    [SerializeField] private Rigidbody2D rb;

    private void Update()
    {
       /* float xMove = joystick.Horizontal();
        float yMove = joystick.Vertical();

        rb.position = new Vector2(xMove, yMove) * speed * Time.deltaTime;*/

    }

}
