using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ID : MonoBehaviour
{
    public SaveSystem save;
    public int idValue;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            save.datas[idValue].yasalio = true;
            string json = JsonHelper.ToJson(save.datas, true);
            File.WriteAllText(Application.streamingAssetsPath + "/GameData.json", json);
        }
    }
}
