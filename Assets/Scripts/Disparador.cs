using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefab;
    public string nombreAccion;

    void Awake(){
        
    }

    void Update(){
        if(Input.GetButtonDown(nombreAccion)){
            InvokeRepeating("Disparar", 0, 0.2f);
        }
        if(Input.GetButtonUp(nombreAccion)){
            CancelInvoke("Disparar");
        }
    }

    public void Disparar(){
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
