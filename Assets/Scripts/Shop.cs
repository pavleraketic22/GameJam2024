using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shopUI; // Referenca na UI shop panela

    void Start()
    {
        if (shopUI != null)
        {
            shopUI.SetActive(false); // Osiguravamo da je shop UI nevidljiv na početku
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Proveravamo da li je objekt koji ulazi igrač
        {
            if (shopUI != null)
            {
                shopUI.SetActive(true); // Prikazujemo shop UI kada igrač uđe u trigger
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        
        if (shopUI != null)
        {
            shopUI.SetActive(false); // Prikazujemo shop UI kada igrač uđe u trigger
        } // Sakrivamo shop UI kada igrač izađe iz trigger-a
    }

    void Update()
    {
        
    }
}
