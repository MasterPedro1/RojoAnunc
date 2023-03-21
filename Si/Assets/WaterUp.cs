using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterUp : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.up * speed * Time.deltaTime;

        // Mover el objeto utilizando el Rigidbody
        rb.MovePosition(transform.position + movement);
    }
}
