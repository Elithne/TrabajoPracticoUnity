using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject prefab;
    public string nombreAccion;

    void Update(){
        if(Input.GetButtonDown(nombreAccion)){
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
