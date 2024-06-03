using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemy : MonoBehaviour
{
    public GameObject enemy;
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
                Vector3 randomSpawn1 = new Vector3(11 , -6, 0);
                Instantiate(enemy, randomSpawn1, Quaternion.identity);

                Vector3 randomSpawn2 = new Vector3( -7, -4, 0);
                Instantiate(enemy, randomSpawn2, Quaternion.identity);

                Vector3 randomSpawn3 = new Vector3( -1 ,4,0);
                Instantiate(enemy, randomSpawn3, Quaternion.identity);
                
                Vector3 randomSpawn4 = new Vector3( 13 ,9,0);
                Instantiate(enemy, randomSpawn4, Quaternion.identity);
                flag = 1;
            }
            
        }
        else
        {
            // if(GameObject.FindGameObjectWithTag("Enemy"))
            // Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            flag = 0;
        }
    }
}
