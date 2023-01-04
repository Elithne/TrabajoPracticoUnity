using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daniador : MonoBehaviour
//Crear un componente llamado "Dañador" que le quite vida al objeto que chocó (GetComponent en OnCollisionEnter, acordarse que el parametro de la colisión es de tipo Collider) y que se destruya a si mismo. La cantidad de daño a inflingir debe sacarse de una propiedad llamada "daño" del componente.
{
    public int danio = 1;

    void OnCollisionEnter(Collision c){
	    Vida vidaDelObjeto = c.gameObject.GetComponent<Vida>();
	    vidaDelObjeto.vida -= danio;
    }
}

