using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneAfterDelay(10f)); // Start the coroutine with a 15-second delay
    }

    IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        Application.Quit(); // Load the new scene
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
