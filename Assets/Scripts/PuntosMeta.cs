using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntosMeta : MonoBehaviour
{
    [SerializeField] Text Puntos;
    int puntos = 0;
    // Imprimi los puntos iniciales
    void Start()
    {
        Puntos.text = "Puntos: " + puntos;
    }

    //Suma o resta puntos dependiendo el objeto con el que se esta colisionando
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            puntos--;
            Puntos.text = "Points: " + puntos;
        } 
        else if (col.gameObject.tag == "Meta")
        {
            puntos++;
            Puntos.text = "Points: " + puntos;
        }
        
    }
}
