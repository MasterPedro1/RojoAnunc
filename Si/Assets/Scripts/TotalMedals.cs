using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalMedals : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI medallasTotal;

    private int _medals;

    void Start()
    {
       
    }

    
    void Update()
    {
        _medals = PlayerPrefs.GetInt("Medallas", 0);
        medallasTotal.text = _medals.ToString();
        _medals = PlayerPrefs.GetInt("Medallas", 0);


    }
}
