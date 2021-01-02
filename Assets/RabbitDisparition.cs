using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitDisparition : MonoBehaviour
{
    SpawnScript spawn_script;

    //Tant qu'on est proche d'un lapin
    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKey(KeyCode.E))
        {
            //on previent le script qu'un lapin est trouve
            spawn_script.rabbit_found();

            //on detruit l'objet
            Destroy(gameObject); 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //on recupere le script de spawn
        spawn_script = GameObject.Find("SpawnLocations").GetComponent<SpawnScript>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}