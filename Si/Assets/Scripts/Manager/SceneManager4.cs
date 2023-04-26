using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager4 : MonoBehaviour
{
    public string Menu;
    public string Restart;
    public string Next;
    public string Moneda;
    public GameObject Pause;
    public GameObject win;
    public GameObject lose;
    public PlayerController PC;
    public GameObject Tienda;
    public GameObject _Menu;
    public GameObject Player;

    private void Update()
    {
        try 
        {
            if (PC.vida <= 0)
            lose.SetActive(true);
           
        }
        catch { }
    }

    public void MenuScene()
    {
       SceneManager.LoadScene(Menu, LoadSceneMode.Single);
        Time.timeScale = 1f;
    }
    public void RestarScene()
    {
        SceneManager.LoadScene(Restart, LoadSceneMode.Single);
        Time.timeScale = 1f;
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(Next, LoadSceneMode.Single);
        Time.timeScale = 1f;
    }

    public void Monedas()
    {
        SceneManager.LoadScene(Moneda, LoadSceneMode.Single);
        Time.timeScale = 1f;
    }

    public void TiendaScene()
    {
        Tienda.gameObject.SetActive(true);
        _Menu.gameObject.SetActive(false);

        Time.timeScale = 1f;

    }public void PlayerScene()
    {
        Player.gameObject.SetActive(true);
        _Menu.gameObject.SetActive(false);

        Time.timeScale = 1f;
    }

    public void MenuG()
    {
        Player.gameObject.SetActive(false);
        Tienda.gameObject.SetActive(false);
        _Menu.gameObject.SetActive(true);

        Time.timeScale = 1f;
    }

    public void IsPause ()
    {
        Pause.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    public void DesPause()
    {
        Pause.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Win()
    {
        win.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Lose()
    {
        lose.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}
