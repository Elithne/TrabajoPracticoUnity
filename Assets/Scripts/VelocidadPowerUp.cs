using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadPowerUp : MonoBehaviour
{
    public int bonus;
    // Crear un componente llamado "VelocidadPowerUp" que tenga una propiedad numerica llamada "bonus" y que acceda al componente "MovimientoPersonaje" del objeto que chocó (GetComponent en el OnTriggerEnter), sumandole el valor de una propiedad "bonus" a la propiedad "velocidadMovimiento" del componente.
    
    void OnTriggerEnter(Collider c){
        //int myLayer = gameObject.layer;
        int collidedLayer = c.gameObject.layer;
	    if(collidedLayer == LayerMask.NameToLayer("Player")){
            MovimientoPersonaje movimientoPersonaje = c.gameObject.GetComponent<MovimientoPersonaje>();
            movimientoPersonaje.velocidadMovimiento += bonus;
            Destroy(gameObject);
        }
    }
}
