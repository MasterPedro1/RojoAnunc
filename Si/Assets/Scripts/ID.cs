using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ID : MonoBehaviour
{
    public SaveSystem save;
    public int idValue;
    public LogrosManager lm;

    private int collectors;
    private void Start()
    {
        if (save.datas[idValue].yasalio == true)
        {
            gameObject.SetActive(false);
        }

        collectors = PlayerPrefs.GetInt("Coleccionable", 0);
    }

    private void Update()
    {
        switch(collectors)
        {
            case 75:
                lm.LogrosId(GPGSIds.achievement_stone_collector);
                break;
            case 100:
                lm.LogrosId(GPGSIds.achievement_wood_collector);
                break;
            case 125:
                lm.LogrosId(GPGSIds.achievement_mineral_collector);
                break;
            case 150:
                lm.LogrosId(GPGSIds.achievement_nuts_collector);
                break;
            case 175:
                lm.LogrosId(GPGSIds.achievement_food_collector);
                break;
            case 180:
                lm.LogrosId(GPGSIds.achievement_cows_collector);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            save.datas[idValue].yasalio = true;
            string json = JsonHelper.ToJson(save.datas, true);
            File.WriteAllText(Application.streamingAssetsPath + "/GameData.json", json);

            collectors = collectors + 1;
            PlayerPrefs.SetInt("Coleccionable", collectors);

        }
    }
}
