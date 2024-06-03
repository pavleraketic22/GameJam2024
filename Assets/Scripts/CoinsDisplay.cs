using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinsDisplay : MonoBehaviour
{
    public static int coinCount = 100;
    public TextMeshProUGUI coinText;

    private void Update()
    {
        coinText.text = "Broj breskvica: " + coinCount.ToString();
    }
}
