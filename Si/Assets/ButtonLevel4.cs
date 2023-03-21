using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLevel4 : MonoBehaviour
{
    public Animator button;
    public Animator button2;


    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            button.Play("Platform");
            button.Play("Button");
        }
    }
}