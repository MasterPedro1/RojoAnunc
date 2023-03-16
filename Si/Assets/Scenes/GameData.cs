using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GameData
{
    
    public int id;
    public string description;
    public bool yasalio;

    public GameData(string description, int id, bool yasalio)
    {

        this.id = id;
        this.description = description;
        this.yasalio = yasalio;

    }

}
