using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitDisparition : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        print("TestEnter");

        if (Input.GetKey(KeyCode.E)) 
        {
            print("TestDestroy");
            Destroy(gameObject); 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}