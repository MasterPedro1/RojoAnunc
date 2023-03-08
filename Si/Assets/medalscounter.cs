using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medalscounter : MonoBehaviour
{
    [SerializeField] private GameObject medal1;
    [SerializeField] private GameObject medal2;
    [SerializeField] private GameObject medal3;

    public PlayerController PC;
    void Update()
    {
        switch(PC.medals)
        {
            case 1:
                medal1.gameObject.SetActive(true);

            break;

            case 2:
                medal1.gameObject.SetActive(true);
                medal2.gameObject.SetActive(true);

            break;

            case 3:
                medal1.gameObject.SetActive(true);
                medal2.gameObject.SetActive(true);
                medal3.gameObject.SetActive(true);

                break;

        }
    }
}
