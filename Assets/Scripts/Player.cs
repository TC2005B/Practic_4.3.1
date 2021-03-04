using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float velocidad;

    Vector3 inicio;

    Vector3 direccion;
    void Start() 
    {
        inicio = GameObject.Find("Player").transform.position;
    }
    // Registra input de direcciones y mueve al jugador
    void Update()
    {
        direccion.x = Input.GetAxisRaw("Horizontal");
        direccion.y = Input.GetAxisRaw("Vertical");
        transform.position = transform.position + direccion * velocidad;
    }

    //Regresa al jugador al incio
    public void restart()
    {
        transform.position = inicio;
    }
}
