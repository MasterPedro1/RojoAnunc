using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public SaveSystem saveSystem;
    public int id;
    
    void Update()
    {
        if (saveSystem.datas[id].yasalio == false)
        {
            print("Te amo kunno");
        }
        else
            print("Soy fan del lorax");
    }
}
