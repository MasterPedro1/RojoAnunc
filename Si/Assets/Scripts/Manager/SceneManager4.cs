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

    private void Update()
    {
        if(PC.vida <= 0)
        {
            lose.SetActive(true);
            //Time.timeScale = 0;
        }
    }

    public void MenuScene()
    {
       SceneManager.LoadScene(Menu);
        Time.timeScale = 1f;
    }
    public void RestarScene()
    {
        SceneManager.LoadScene(Restart);
        Time.timeScale = 1f;
    }
    public void TiendaScene()
    {
        Tienda.gameObject.SetActive(true);
        _Menu.gameObject.SetActive(false);

        Time.timeScale = 1f;
    }

    public void MenuG()
    {
        Tienda.gameObject.SetActive(false);
        _Menu.gameObject.SetActive(true);

        Time.timeScale = 1f;
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(Next);
        Time.timeScale = 1f;
    }

    public void Monedas()
    {
        SceneManager.LoadScene(Moneda);
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
