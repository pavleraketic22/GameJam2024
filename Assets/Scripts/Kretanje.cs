using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Kretanje : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0.00001f;

    public GameObject karaokePng;
    // Start is called before the first frame update
    void Start()
    {
        if (karaokePng != null)
        {
            karaokePng.SetActive(false); // Osiguravamo da je shop UI nevidljiv na početku
        }
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * movementSpeed;
        float moveVertical = Input.GetAxis("Vertical") * movementSpeed;
        if (moveVertical != 0)
        {
            transform.Translate(0, moveVertical, 0);
        }
        // Pomeranje lika levo/desno
        else if (moveHorizontal != 0)
        {
            transform.Translate(moveHorizontal, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Breskva"))
        {
            Destroy(other.gameObject);
            CoinsDisplay.coinCount++;
        }else if (other.gameObject.CompareTag("Publika"))
        {
            if (karaokePng != null)
            {
                karaokePng.SetActive(true); // Prikazujemo shop UI kada igrač uđe u trigger
            }
        } else if (other.gameObject.CompareTag("Enemy"))
        {
            CoinsDisplay.coinCount--;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Publika"))
        {
            Destroy(other.gameObject);
        }
    }
}
