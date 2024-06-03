using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndCutscene : MonoBehaviour{


    public string sceneName = "MainMenu"; // Name of the scene to load

    void Start()
    {
        StartCoroutine(LoadSceneAfterDelay(16f)); // Start the coroutine with a 15-second delay
    }

    IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        SceneManager.LoadScene(sceneName); // Load the new scene
    }

    
    void Update()
    {
        
    }
}
