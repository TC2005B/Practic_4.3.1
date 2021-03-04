using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    [SerializeField] Enemys enemy;
    int counter = 0;

    //Funcion que identifica con que borde se colisiona un enemigo y en base a eso, decide hacia que lado moverse
    void OnTriggerEnter2D(Collider2D col)
    {
        counter++;
        if (counter % 2 != 0)
        {
            enemy.ChangeMoveL();
        }
        else if (counter % 2 == 0)
        {
            enemy.ChangeMoveR();
        } 
    }
}
