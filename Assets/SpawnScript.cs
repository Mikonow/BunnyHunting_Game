using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class SpawnScript : MonoBehaviour
{
    //prefab du lapin
    public GameObject lapin;

    //groupe contenant les lapins
    public GameObject groupelapin;

    //nombre de lapin a spawn
    int numbertospawn = 20;

    //nombre de lapin trouves
    int rabbitfound = 0;

    //Affichage
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //tableau qui liste les composants des enfants de SpawnLocations
        Transform[] allChildren = GetComponentsInChildren<Transform>();

        //on converti notre tableau en liste
        List<Transform> children = new List<Transform>(allChildren);

        //Liste des index pour les spawns
        List<int> spawnindexes = new List<int>();

        //On enlève le transform de SpawnLocations si non on aura un lapin dans le vide lol
        children.RemoveAt(0);

        //On genere une liste d'index de location
        while(spawnindexes.Count < numbertospawn) {

            int newindex = Random.Range(0, children.Count);

            //Si l'index n'est pas deja dans la liste, on l'ajoute
            if (!spawnindexes.Contains(newindex)) {
                spawnindexes.Add(newindex);
            }
        }

        foreach (int index in spawnindexes)
        {
            //on met les lapins dans le groupe ChocolateRabbits pour qu'ils scalent à la bonne taille
            GameObject currentlapin = Instantiate(lapin, groupelapin.transform);

            //On recupere la position depuis l'index
            Transform positionlapin = children[index];

            //On deplace le lapin au bon endroit
            currentlapin.transform.position = new Vector3(positionlapin.position.x, positionlapin.position.y, positionlapin.position.z);
        }
    }

    //gere la decouverte d'un lapin
    public void rabbit_found()
    {
        rabbitfound++;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = rabbitfound.ToString() + " / " + numbertospawn.ToString() + " rabbits found";
    }
}
