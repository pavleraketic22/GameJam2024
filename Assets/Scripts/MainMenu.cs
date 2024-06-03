using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Screen = UnityEngine.Device.Screen;

public class Play : MonoBehaviour
{


    public void PlayClick()
    {
        SceneManager.LoadScene("PlayScene");

    }
    
    public void MainClick()
    {
        SceneManager.LoadScene("MainMenu");

    }

    public void ExitClick()
    {
        Application.Quit();
    }

    public void ControlsClick()
    {
        SceneManager.LoadScene("ControlScene");
    }


}
