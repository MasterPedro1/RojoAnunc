using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    [Header("Player")]
    public bool isLeft = false;
    public bool isRight = false;
    public bool isUp = false;
    public bool isAttack = false;

    public Rigidbody2D rb;
    public float speed;
    public float jump;
    public GameObject swordo;

    [Header("Animator")]

    public Animator animator;
    public TMP_Text tmp;
    public string run, idle, jump2, hurt;
    [SerializeField] private SpriteRenderer sp;


    [Header("La UI")]
    public float vida;
    public float medals;
    public GameObject medal1, medal2, medal3;


   
   

    private void Start()
    {
        
       
    }


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
    
    public void clickAttack()
    {
        isAttack = true;
    }

    public void releaseAttack()
    {
        isAttack = false;
        swordo.gameObject.SetActive(false);
    }




    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jump, 0) * Time.deltaTime);
           
        }
        tmp.text = "X  " + vida;

    }
    private void FixedUpdate()
    {
        if (isLeft == false && isRight == false && isUp == false)
            animator.Play(idle);

        if (isLeft)
        {
            //rb.AddForce(new Vector2(-speed, 0) * Time.deltaTime);
            rb.transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            animator.Play(run);
            sp.flipX = true;

        }

        if (isRight)
        {
            //rb.AddForce(new Vector2(speed, 0) * Time.deltaTime);
            rb.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            animator.Play(run);
            sp.flipX = false;
        }

        if (isUp)
        {
            //rb.AddForce(new Vector2(speed, 0) * Time.deltaTime);
            rb.transform.position += new Vector3(0, speed * 2f, 0) * Time.deltaTime;
            animator.Play(jump2);
        }

        if (isAttack)
        {
            swordo.gameObject.SetActive(true);
            animator.Play("Attack");
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            animator.Play(hurt);
            vida = vida - 1;
        }

        if(collision.CompareTag("Health"))
        {
            vida = vida + 1;
            collision.gameObject.SetActive(false);
            

        }

        if (collision.CompareTag("Medal"))
        {
            medals = medals + 1;
            collision.gameObject.SetActive(false);
            switch(medals)
            {
                case 1:
                medal1.gameObject.SetActive(true);

                 break;
                case 2:
                    medal2.gameObject.SetActive(true);

                    break;
                case 3:
                    medal3.gameObject.SetActive(true);

                    break;

            }

        }

        if (collision.CompareTag("Water"))
        {
            vida = vida - 5f;
        }


    }
    public void Attack()
    {
       
    }



}
