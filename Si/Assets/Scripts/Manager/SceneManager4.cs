using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager4 : MonoBehaviour
{
    public string Scene1;
    public string Scene2;
    public string Scene3;
    

    public void ScenePrim()
    {
       SceneManager.LoadScene(Scene1);
    }
    public void SceneSec()
    {
        SceneManager.LoadScene(Scene2);
    }
    public void SceneTerc()
    {
        SceneManager.LoadScene(Scene3);
    }
}
