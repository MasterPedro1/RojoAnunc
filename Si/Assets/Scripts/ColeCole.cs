using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ColeCole : MonoBehaviour
{
    public int id;
    public SaveSystem sv;
    public GameObject go;


    private void Start()
    {
        sv.json = File.ReadAllText(Application.streamingAssetsPath + "/GameData.json");
        sv.datas = JsonHelper.FromJson<GameData>(sv.json);
    }
    private void Update()
    {
        
        if(sv.datas[id].yasalio == true)
        {
            go.SetActive(true);
        }
        

    }
}
