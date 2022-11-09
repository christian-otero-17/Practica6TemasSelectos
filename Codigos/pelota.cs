using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "piso")
          print("La pelota choco");
          Object.Destroy(this.gameObject);
    }
    public bool activaPelota;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
