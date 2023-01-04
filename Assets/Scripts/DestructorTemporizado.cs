using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorTemporizado : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Invoke("Destruir", 2.0f);
    }

    public void Destruir(){
        Destroy(gameObject);
    }
}
