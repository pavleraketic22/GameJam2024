using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class People : MonoBehaviour
{
    public static int people = 25;
    public TextMeshProUGUI coinText;

    

    private void Update()
    {
        coinText.text = "Broj ljudi: " + people.ToString() + "/20";
        if (people >= 20 && Kupi.torta == 1)
        {
            
            SceneManager.LoadScene("KrajUspeh");
        }
    }
}
