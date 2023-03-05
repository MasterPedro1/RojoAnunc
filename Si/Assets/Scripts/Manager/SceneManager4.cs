using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager4 : MonoBehaviour
{
    public string Scene1;
    public string Scene2;
    public string Scene3;
    public GameObject Pause;
    public GameObject win;
    public GameObject lose;

    public void ScenePrim()
    {
       SceneManager.LoadScene(Scene1);
        Time.timeScale = 1f;
    }
    public void SceneSec()
    {
        SceneManager.LoadScene(Scene2);
        Time.timeScale = 1f;
    }
    public void SceneTerc()
    {
        SceneManager.LoadScene(Scene3);
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
