using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    private int _money;
    private int _skin;

    public bool green = false;
    public bool black = false;
    public bool red = false;

    public GameObject yoursgreen;
    public GameObject yoursblack;
    public GameObject yoursred; 
    public GameObject byegreen;
    public GameObject byeblack;
    public GameObject byered;

    public GameObject Equigreen;
    public GameObject Equiblack;
    public GameObject Equipred; 
    
    public GameObject Quitgreen;
    public GameObject Quitblack;
    public GameObject Quitred;
    public GameObject QuitNorm;

   

    public AudioClip nel;
    public AudioSource nol;

    private int greenValue;
    private int blackValue;
    private int redValue;
    private int playerid;

    

    void Start()
    {
        _money = PlayerPrefs.GetInt("Medallas", 0);

       
        
    }

    private void Update()
    {
        greenValue = PlayerPrefs.GetInt("GreenID", 0);
        blackValue = PlayerPrefs.GetInt("BlackID", 0);
        redValue = PlayerPrefs.GetInt("RedID", 0);
        playerid = PlayerPrefs.GetInt("PlayerId", 0);

        if (greenValue == 1)
        {
            yoursgreen.SetActive(true);
            byegreen.SetActive(false);
            Equigreen.SetActive(true);
        }

        if(blackValue == 1)
        {
            yoursblack.SetActive(true);
            byeblack.SetActive(false);
            Equiblack.SetActive(true);
        }

        if(redValue == 1)
        {
            yoursred.SetActive(true);
            byered.SetActive(false);
            Equipred.SetActive(true);
        }

        
        switch (playerid)
        {
            case 0:
                Quitblack.SetActive(false);
                Quitred.SetActive(false);
                Quitgreen.SetActive(false);
                QuitNorm.SetActive(true);
                break;

            case 1:
                Quitblack.SetActive(false);
                Quitred.SetActive(false);
                Quitgreen.SetActive(true);
                QuitNorm.SetActive(false);
                break;

            case 2:
                Quitblack.SetActive(false);
                Quitred.SetActive(true);
                Quitgreen.SetActive(false);
                QuitNorm.SetActive(false);
                break;

            case 3:
                Quitblack.SetActive(true);
                Quitred.SetActive(false);
                Quitgreen.SetActive(false);
                QuitNorm.SetActive(false);
                break;
        }

        
    }


    public void BuyGreen()
    {
        if (green == false)
        {
            
            if (_money >= 3)
            {
                green = true;
                _money = _money - 3;
                PlayerPrefs.SetInt("Medallas", _money);
                yoursgreen.SetActive(true);
                byegreen.SetActive(false);
                greenValue = greenValue + 1;
                PlayerPrefs.SetInt("GreenID", greenValue);
            }
            else
            nol.PlayOneShot(nel);
    
            
        }
    }


    public void BuyBlack()
    {
        if (black == false)
        {

            if (_money >= 3)
            {
                black = true;
                _money = _money - 3;
                PlayerPrefs.SetInt("Medallas", _money);
                yoursblack.SetActive(true);
                byeblack.SetActive(false);
                blackValue = blackValue + 1;
                PlayerPrefs.SetInt("BlackID", blackValue);
            }
            else
                nol.PlayOneShot(nel);


        }

    }


    public void BuyRed()
    {
        if (red == false)
        {

            if (_money >= 3)
            {
                red = true;
                _money = _money - 3;
                PlayerPrefs.SetInt("Medallas", _money);
                yoursred.SetActive(true);
                byered.SetActive(false);
                redValue = redValue + 1;
                PlayerPrefs.SetInt("RedID", redValue);
            }
            else
                nol.PlayOneShot(nel);


        }

    }

    public void EquipeNormal()
    {
        playerid = 0;
        PlayerPrefs.SetInt("PlayerId", playerid);
        Quitblack.SetActive(false);
        Quitred.SetActive(false);
        Quitgreen.SetActive(false);
        QuitNorm.SetActive(true);

    } 
    
    public void EquipeGreen()
    {
        playerid = 1;
        PlayerPrefs.SetInt("PlayerId", playerid);
        Quitblack.SetActive(false);
        Quitred.SetActive(false);
        Quitgreen.SetActive(true);
        QuitNorm.SetActive(false);


    } 
    
    public void EquipeRed()
    {
        playerid = 2;
        PlayerPrefs.SetInt("PlayerId", playerid);
        Quitblack.SetActive(false);
        Quitred.SetActive(true);
        Quitgreen.SetActive(false);
        QuitNorm.SetActive(false);


    }

    public void EquipeBlack()
    {
        playerid = 3;
        PlayerPrefs.SetInt("PlayerId", playerid);
        Quitblack.SetActive(true);
        Quitred.SetActive(false);
        Quitgreen.SetActive(false);
        QuitNorm.SetActive(false);


    }
}
