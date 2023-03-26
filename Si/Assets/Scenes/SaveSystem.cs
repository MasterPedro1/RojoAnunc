using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class SaveSystem : MonoBehaviour
{
    public GameData[] datas;
    public string json;
    // Start is called before the first frame update
    void Start()
    {
        
        json = File.ReadAllText(Application.streamingAssetsPath + "/GameData.json");
        datas = JsonHelper.FromJson<GameData>(json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public static class JsonHelper
{
    public static T[] FromJson<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Coleccionables;
    }

    public static string ToJson<T>(T[] array)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Coleccionables = array;
        return JsonUtility.ToJson(wrapper);
    }

    public static string ToJson<T>(T[] array, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Coleccionables = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    [Serializable]
    private class Wrapper<T>
    {
        public T[] Coleccionables;
    }
}