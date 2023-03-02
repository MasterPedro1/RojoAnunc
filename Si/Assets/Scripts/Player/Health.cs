using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Rigidbody2D rb;
    public float push;
    public PlayerController player;
    [SerializeField] private SpriteRenderer sp;
    public bool IsHurt = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
           
            
            if (player.isLeft == true)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.right * push);
                Debug.Log("Left");
            }

            if (player.isRight == true)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector3.left * push);
                Debug.Log("Contacto");
            }
        }
    }
}
