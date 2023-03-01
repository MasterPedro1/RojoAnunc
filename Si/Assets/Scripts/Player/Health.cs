using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.collider.CompareTag("Enemy"))
        {
            rb.AddForce(new Vector2(1, 1) * Time.deltaTime);
        }

    }
}
