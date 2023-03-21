using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colectables : MonoBehaviour
{
    public GameObject lista;
    public GameObject piedras;
    public GameObject maderas;
    public GameObject minerales;
    public GameObject frutos_Secos;
    public GameObject comida;
    public GameObject vacas;

    public string menu;
    

    public void Lista()
    {
        piedras.SetActive(false);
        maderas.SetActive(false);
        minerales.SetActive(false);
        frutos_Secos.SetActive(false);
        comida.SetActive(false);
        vacas.SetActive(false);
        lista.SetActive(true);
    }

    public void Piedra()
    {
        piedras.SetActive(true);
        lista.SetActive(false) ;
    }

    public void Madera()
    {
        lista.SetActive(false);
        maderas.SetActive(true);
    }

    public void Mineral()
    {
        lista.SetActive(false);
        minerales.SetActive(true);
    }

    public void Frutos()
    {
        lista.SetActive(false);
        frutos_Secos.SetActive(true);
    }

    public void Comida()
    {
        lista.SetActive(false);
        comida.SetActive(true);
    }

    public void Vacas()
    {
        lista.SetActive(false);
        vacas.SetActive(true);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
