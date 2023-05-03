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
    public GameObject swordo2;
    public LogrosManager lm;

    private int jumps;
    private int water;

    [Header("Animator")]

    public Animator animator;
    public TMP_Text tmp;
    public string run, idle, jump2, hurt;

    [SerializeField] private SpriteRenderer sp;



    [Header("La UI")]
    public float vida;
    public int medals;
    public GameObject medal1, medal2, medal3;

    private int totalmedals;

    [Header("Audio")]

    public AudioClip coin;
    public AudioClip medal;
    public AudioClip atttack;
    public AudioSource source;
   

    private void Start()
    {
        Animator animator = GetComponent<Animator>();
        totalmedals = PlayerPrefs.GetInt("Medallas", 0);
        jumps = PlayerPrefs.GetInt("Jump", 0);
        GetComponent<LogrosManager>();
        

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
        jumps = jumps + 1;
    }

    public void releaseUp()
    {
        isUp = false;
    }
    
    public void clickAttack()
    {
        isAttack = true;
        source.PlayOneShot(atttack);
    }

    public void releaseAttack()
    {
        isAttack = false;
        swordo.gameObject.SetActive(false);
        swordo2.gameObject.SetActive(false);
    }




    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.transform.position += new Vector3(0, speed * 2f, 0) * Time.deltaTime; ;
           
        }
        tmp.text = "X  " + vida;

        PlayerPrefs.SetInt("Medallas", totalmedals);
        PlayerPrefs.SetInt("Jump", jumps);

        switch (jumps) 
        {
            case 30:
                lm.LogrosId(GPGSIds.achievement_noob_jumper);
                break;
            case 40:
                lm.LogrosId(GPGSIds.achievement_normal_jumper);
                break;
            case 50:
                lm.LogrosId(GPGSIds.achievement_advanced_jumper);
                break;
            case 70:
                lm.LogrosId(GPGSIds.achievement_expert_jumper);
                break;
            case 100:
                lm.LogrosId(GPGSIds.achievement_insane_jumper);
                break;

        }

        switch (totalmedals)
        {
            case 3:
                lm.LogrosId(GPGSIds.achievement_noob_medal_collector);
                break;
            case 6:
                lm.LogrosId(GPGSIds.achievement_advance_medal_collector);
                break;
            case 9:
                lm.LogrosId(GPGSIds.achievement_insane_medal_collector);
                break;

        }

    }
    private void FixedUpdate()
    {

        if (isLeft == false && isRight == false && isUp == false)
            //animator.Play(idle);

            animator.SetBool("Idle", true);
            animator.SetBool("Jump", false);
            animator.SetBool("Attack", false);
            animator.SetBool("Hurt", false);
            animator.SetBool("Run", false);

        if (isLeft)
        {
            //rb.AddForce(new Vector2(-speed, 0) * Time.deltaTime);
            rb.transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime;
            animator.SetBool("Jump", false);
            animator.SetBool("Attack", false);
            animator.SetBool("Idle", false);
            animator.SetBool("Hurt", false);
            animator.SetBool("Run", true);
            //animator.Play(run);
            sp.flipX = true;

        }

        if (isRight)
        {
            //rb.AddForce(new Vector2(speed, 0) * Time.deltaTime);
            rb.transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            animator.SetBool("Jump", false);
            animator.SetBool("Attack", false);
            animator.SetBool("Idle", false);
            animator.SetBool("Hurt", false);
            animator.SetBool("Run", true);
            //animator.Play(run);
            sp.flipX = false;
        }

        if (isUp)
        {
            //rb.AddForce(new Vector2(speed, 0) * Time.deltaTime);
            rb.transform.position += new Vector3(0, speed * 2f, 0) * Time.deltaTime;
            animator.SetBool("Jump", true);
            animator.SetBool("Idle", false);
            animator.SetBool("Attack", false);
            animator.SetBool("Run", false);
            animator.SetBool("Hurt", false);
            //animator.Play(jump2);
            
        }

        if (isAttack)
        {

            if(sp.flipX == false)
            {
                swordo.gameObject.SetActive(true);
            }
            else
                swordo2.gameObject.SetActive(true);

            animator.SetBool("Attack", true);
            animator.SetBool("Idle", false);
            animator.SetBool("Run", false);
            animator.SetBool("Hurt", false);
            animator.SetBool("Jump", false);
            //animator.Play("Attack");
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            animator.SetBool("Attack", false);
            animator.SetBool("Idle", false);
            animator.SetBool("Run", false);
            animator.SetBool("Hurt", true);
            animator.SetBool("Jump", false);
            // animator.Play(hurt);
            //vida = vida - 1;
        }

        if (collision.CompareTag("Health"))
        {
            vida = vida + 1;
            collision.gameObject.SetActive(false);


        }

        if (collision.CompareTag("Medal"))
        {
            medals = medals + 1;
            source.PlayOneShot(medal);
            totalmedals = totalmedals + 1;

            Destroy(collision.gameObject);
            switch (medals)
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
            vida = vida - 10f;
            lm.LogrosId(GPGSIds.achievement_you_need_swimming_lessons);

        }

        if (collision.CompareTag("Coins"))
        {
            
            source.PlayOneShot(coin);
            collision.gameObject.SetActive(false);
        }


    }
   


}
