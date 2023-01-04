using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    public GameObject prefab;

    void Awake(){
        InvokeRepeating("Disparar", 1.0f, 2.0f);
    }

    public void Disparar(){
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
