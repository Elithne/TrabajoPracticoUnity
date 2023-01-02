using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    public GameObject prefab;


    void Awake(){
        Instantiate(prefab, transform.position, transform.rotation);        
    }
}
