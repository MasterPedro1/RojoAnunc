using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkin : MonoBehaviour
{
    private int playerskin;
    public SpriteRenderer sp;

    private void Update()
    {
        playerskin =  PlayerPrefs.GetInt("PlayerId", 0);

        switch (playerskin)
        {
            case 0:
                sp.color = Color.white;

                break;

            case 1:
                sp.color = Color.green;
                break;

            case 2:
                sp.color = Color.red;
                break;

            case 3:
                sp.color = Color.black;
                break;
        }
    }
}
