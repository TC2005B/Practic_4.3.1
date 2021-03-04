using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    [SerializeField] Player player;

    //Mueve jugador a incio cuando llega a la meta
    void OnCollisionEnter2D(Collision2D collision)
    {
        player.restart();
    }   
}
