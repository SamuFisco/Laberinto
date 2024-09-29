using System.Collections;
using System.Collections.Generic;
using UnityEngine; //Librerias


public class MovimientoJugador : MonoBehaviour //Clase

{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;


    public float velocidadMovimiento = 1.5f;
    // Start is called before the first frame update// Se ejecuta antes del Play
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeZ = - Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;//para que el movimiento total en un segundo sea el mismo en cualquier equipo ( * Time.deltaTime) velocidadMovimiento 
        movimientoEjeX = - Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento; //para que el movimiento total en un segundo sea el mismo en cualquier equipo ( * Time.deltaTime)
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
