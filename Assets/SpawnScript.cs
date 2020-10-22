using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    //prefab du lapin
    public GameObject lapin;

    //groupe contenant les lapins
    public GameObject groupelapin;

    // Start is called before the first frame update
    void Start()
    {
        //tableau qui liste les composants des enfants de SpawnLocations
        Transform[] allChildren = GetComponentsInChildren<Transform>();

        //on converti notre tableau en liste
        List<Transform> children = new List<Transform>(allChildren);

        //On enlève le transform de SpawnLocations si non on aura un lapin dans le vide lol
        children.RemoveAt(0);

        foreach(Transform child in children)
        {
            //on met les lapins dans le groupe ChocolateRabbits pour qu'ils scalent à la bonne taille
            GameObject currentlapin = Instantiate(lapin, groupelapin.transform);

            //on assigne les lapins aux différentes positions situées dans les transform des child de SpawnLocations
            currentlapin.transform.position = new Vector3(child.position.x, child.position.y, child.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
