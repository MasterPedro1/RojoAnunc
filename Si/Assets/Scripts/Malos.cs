using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malos : MonoBehaviour
{
    [SerializeField] private PlayerController pc;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pc.vida = pc.vida - 1;
            Debug.Log("Daño");
        }
    }
}
