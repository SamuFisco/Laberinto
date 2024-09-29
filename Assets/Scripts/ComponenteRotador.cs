using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteRotador : MonoBehaviour
{
    [SerializeField]
    float rotationY = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, rotationY * Time.deltaTime, 0f); // Time.deltaTime para que en todos los equipos funcione a la misma velocidad
    }
}
