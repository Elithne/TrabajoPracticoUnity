using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public GameObject bomba;
    void Update()
    {
        if(Input.GetButton("Explotar")){
            Destroy(bomba);
        }
    }
}
