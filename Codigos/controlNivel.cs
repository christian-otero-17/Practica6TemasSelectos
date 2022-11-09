using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlNivel : MonoBehaviour
{
    public GameObject pelota;
    public Transform inicioPelota;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            print("Se creo pelota");
            Instantiate(pelota, inicioPelota);
    }
}
