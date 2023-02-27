using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isLeft = false;
    bool isRight = false;

    public Rigidbody2D rb;
    public float speed;



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

    private void FixedUpdate()
    {
        if (isLeft)
        {
            rb.transform.position = new Vector2(-speed, 0) * Time.deltaTime;
        }

        if (isRight)
        {
            rb.transform.position = new Vector2(speed, 0) * Time.deltaTime;
        }
    }
}
