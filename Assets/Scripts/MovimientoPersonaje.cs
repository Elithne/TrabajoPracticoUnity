using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadMovimiento;
    public float velocidadRotacion;

    void Update()
    {
        if(Input.GetButton("Arriba")){
            transform.Translate(0, 0, velocidadMovimiento * Time.deltaTime); 
        }
        if(Input.GetButton("Abajo")){
            transform.Translate(0, 0, -(velocidadMovimiento * Time.deltaTime));
        }
        if(Input.GetButton("Derecha")){
            transform.Rotate(0,velocidadRotacion * Time.deltaTime, 0);
        }
        if(Input.GetButton("Izquierda")){
            transform.Rotate(0, -(velocidadRotacion * Time.deltaTime), 0);            
        }
    }
}
