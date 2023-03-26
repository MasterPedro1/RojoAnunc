using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ColeCole : MonoBehaviour
{
    public int id = 0;
    public int idGO = 0;
    public List<GameObject> gameObjects = new List<GameObject>();
    public SaveSystem sv;


    private void Start()
    {
        sv.json = File.ReadAllText(Application.streamingAssetsPath + "/GameData.json");
        sv.datas = JsonHelper.FromJson<GameData>(sv.json);
    }
    private void Update()
    {

        for ( id = 0; id <= 180; id++)
        {
            for ( idGO = 0; idGO <= 180; idGO++)
            {
                if (sv.datas[id].yasalio == true)
                {
                    gameObjects[idGO].SetActive(true);
                }
            }
        }

    }
}
