using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorOleadas : MonoBehaviour
{
    public GameObject prefab;

    void Awake(){
        InvokeRepeating("CrearPrefab", 1.0f, 2.0f);
    }

    public void CrearPrefab(){
        Instantiate(prefab,transform.position, transform.rotation);
    }    
}
