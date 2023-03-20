using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject objeto; 
    public float tiempoDeEspera = 5f;

    void Start()
    {
        StartCoroutine(ActivarDesactivarObjetoRoutine());
    }

    IEnumerator ActivarDesactivarObjetoRoutine()
    {
        while (true)
        {
            objeto.SetActive(true); 
            yield return new WaitForSeconds(tiempoDeEspera); 
            objeto.SetActive(false); 
            yield return new WaitForSeconds(tiempoDeEspera); 
        }
    }
}
