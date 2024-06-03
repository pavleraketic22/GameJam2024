using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomPublika : MonoBehaviour
{
    public GameObject publika;
    private static List<GameObject> napravljeneBreskve = new List<GameObject>();
    private static int flag = 0;
    public LayerMask layerMask;
    public List<GameObject> objekti;
    

    // Update is called once per frame
    void Update()
    {
         
        if (WorldTIme.vreme >= 5 && WorldTIme.vreme <= 21)
        {
            
            if (flag == 0)
            {
                Vector3 randomSpawn1 = new Vector3(-1 , 0, 0);
                Instantiate(publika, randomSpawn1, Quaternion.identity);

                Vector3 randomSpawn2 = new Vector3( 12, 5, 0);
                Instantiate(publika, randomSpawn2, Quaternion.identity);

                Vector3 randomSpawn3 = new Vector3( 21 ,2,0);
                Instantiate(publika, randomSpawn3, Quaternion.identity);
                
                Vector3 randomSpawn4 = new Vector3( -4 ,10,0);
                Instantiate(publika, randomSpawn4, Quaternion.identity);
                flag = 1;
                Debug.Log("NAPRAVIO");
            }
            
        }
        else
        {
            flag = 0;
        }
    }
}
