using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPush : MonoBehaviour
{
    public Animator door;
    public Animator door2;
    public Animator door3;
    public Animator door4;
    public Animator button;


    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            door.Play("Door");
            door2.Play("Door");
            door3.Play("Door");
            door4.Play("Door");
            button.Play("Button");
            print("Pum");
        }
    }
}
