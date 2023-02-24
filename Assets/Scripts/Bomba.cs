using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public GameObject bomba;
    public bool explotar = false;

    public void Awake(){
        Invoke("ExplotarBomba", 7.0f);
    }

    public void Update(){
        if(Input.GetButton("Explotar")){
            explotar = true;
            print(explotar);
        }
    }

    public void OnTriggerStay(Collider c){
	    
        if(explotar && c.gameObject.tag != "Boundaries"){
            Destroy(c.gameObject);
            Destroy(bomba);
            explotar = false;
        }
    }

    public void ExplotarBomba(){
        explotar = true;
    }
}
