using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Break();
        Debug.Log("Terrain");
      
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Break();
        Debug.Log("Terrain");
        
    }
}
