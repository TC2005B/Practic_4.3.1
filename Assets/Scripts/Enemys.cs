using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    [SerializeField] float delay;

    [SerializeField] float speed;

    void Start()
    {
        InvokeRepeating("MoveR", 0, delay);
    }
    // Mover enemigo izquierda
    void MoveL()
    {
        transform.position = transform.position + Vector3.left * speed;
    }
    // Mover enemigo derecha
    void MoveR()
    {
        transform.position = transform.position + Vector3.right * speed;
    }
    //Cambiar sentido de movimiento 
    public void ChangeMoveL()
    {
        CancelInvoke();
        InvokeRepeating("MoveL", 0, delay);
    }
    //Cambiar sentido de movimiento
    public void ChangeMoveR()
    {
        CancelInvoke();
        InvokeRepeating("MoveR", 0, delay);
    }

}
