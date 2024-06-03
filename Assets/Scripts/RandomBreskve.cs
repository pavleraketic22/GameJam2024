using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class RandomBreskve : MonoBehaviour
{

    public GameObject breskva;
    private static List<GameObject> napravljeneBreskve = new List<GameObject>();
    private static int flag = 0;
    public LayerMask layerMask;
    public List<GameObject> objekti;
    

    // Update is called once per frame
    void Update()
    {
         
        if ((WorldTIme.vreme >= 0 && WorldTIme.vreme <= 5) || (WorldTIme.vreme >= 21))
        {
            
            if (flag == 0)
            {
                Vector3 randomSpawn1 = new Vector3(0 , 0, 0);
                Instantiate(breskva, randomSpawn1, Quaternion.identity);

                Vector3 randomSpawn2 = new Vector3( -1, 3, 0);
                Instantiate(breskva, randomSpawn2, Quaternion.identity);

                Vector3 randomSpawn3 = new Vector3( 2 ,1,0);
                Instantiate(breskva, randomSpawn3, Quaternion.identity);
                flag = 1;
            }
            
        }
        else
        {
            // Destroy(GameObject.FindGameObjectWithTag("Breskva"));
            flag = 0;
        }
    }
}
