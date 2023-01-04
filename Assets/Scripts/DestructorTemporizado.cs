using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorTemporizado : MonoBehaviour
{
    public int segundosDestruccion;
    void Awake()
    {
        Invoke("Destruir", segundosDestruccion);
    }

    public void Destruir(){
        Destroy(gameObject);
    }
}
