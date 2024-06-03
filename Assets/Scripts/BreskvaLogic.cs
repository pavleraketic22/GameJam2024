using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreskvaLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!(WorldTIme.vreme >= 0 && WorldTIme.vreme <= 5) && !(WorldTIme.vreme >= 21))
        {
            Destroy(gameObject);
            return;
        }
    }
}
