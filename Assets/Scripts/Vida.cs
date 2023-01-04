using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public int vida;
    
    void Update()
    {
        if(vida <= 0){
            Destroy(gameObject);
        }
    }
}
