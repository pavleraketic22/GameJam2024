using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dani : MonoBehaviour
{
    public static int people = 25;
    public TextMeshProUGUI dani;

    private void Update()
    {
        dani.text = "Dan broj: " + WorldTIme.dani.ToString() + "/5";
        
    }
}
