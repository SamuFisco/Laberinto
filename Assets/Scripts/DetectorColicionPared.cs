using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColicionPared : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;

    [SerializeField]
    Material paredTocada;

    bool paredRoja = false;

    float tiempoEnRojo = 5f;

    private void Update() //se ejecuta por cada imagen del juego
    {
        if(paredRoja == true)
        {
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;
            if (tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialPorDefecto;
                paredRoja = false;
                tiempoEnRojo = 5f; //Restablece tiempo despues de chocas para que de rojo pase de nuevo a blanco
            }
        }
    }

    //se ejecuta al chocar un objeto con este gameObject.
    private void OnCollisionEnter (Collision col)
    {
      
        if(col.gameObject.tag == "Player")
        {
            //Debug.Log(col.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = paredTocada; // así podemos acceder al material para ponerlo en rojo al chocar
            paredRoja = true;
        }
    }
}
