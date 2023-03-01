using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    bool isLeft = false;
    bool isRight = false;
    bool isUp = false;

    public Rigidbody2D rb;
    public float speed;
    public float jump;



    public void clickLeft()
    {
        isLeft = true;
    }

    public void releaseLeft()
    {
        isLeft = false;
    }

    public void clickRight()
    {
        isRight = true;
    }

    public void releaseRight()
    {
        isRight = false;
    }

    public void clickUp()
    {
        isUp = true;
    }

    public void releaseUp()
    {
        isUp = false;
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jump, 0) * Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {
        

        if (isLeft)
        {
            //rb.AddForce(new Vector2(-speed, 0) * Time.deltaTime);
            rb.transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
        }

        if (isRight)
        {
            //rb.AddForce(new Vector2(speed, 0) * Time.deltaTime);
            rb.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if (isUp)
        {
            //rb.AddForce(new Vector2(speed, 0) * Time.deltaTime);
            rb.transform.position += new Vector3(0, speed * 2f, 0) * Time.deltaTime;
        }

    }


   
}
