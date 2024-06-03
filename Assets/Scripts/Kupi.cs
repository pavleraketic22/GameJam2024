using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kupi : MonoBehaviour
{
    public static int svecice = 0;
    public static int brasno = 0;
    public static int jaja = 0;
    public static int mleko = 0;
    public static int secer = 0;
    public static int slag = 0;
    public static int torta = 0;
    
    
    
    public void kupiSvecice()
    {
        if (svecice == 1)
        {
            return;
        }
        if (CoinsDisplay.coinCount >= 15)
        {
            CoinsDisplay.coinCount -= 15;
            svecice = 1;
        }
        
    }
    public void kupiBrasno()
    {
        if (brasno == 1)
        {
            return;
        }
        if (CoinsDisplay.coinCount >= 5)
        {
            CoinsDisplay.coinCount -= 5;
            brasno = 1;
        }
        
    }
    
    public void kupiJaja()
    {
        if (jaja == 1)
        {
            return;
        }
        if (CoinsDisplay.coinCount >= 9)
        {
            CoinsDisplay.coinCount -= 9;
            jaja = 1;
        }
        
    }
    
    public void kupiSlag()
    {
        if (slag == 1)
        {
            return;
        }
        if (CoinsDisplay.coinCount >= 10)
        {
            CoinsDisplay.coinCount -= 10;
            slag = 1;
        }
        
    }
    
    public void kupiSecer()
    {
        if (secer == 1)
        {
            return;
        }
        if (CoinsDisplay.coinCount >= 3)
        {
            CoinsDisplay.coinCount -= 3;
            secer = 1;
        }
    }
    
    public void kupiMleko()
    {
        if (mleko == 1)
        {
            return;
        }
        if (CoinsDisplay.coinCount >= 8)
        {
            CoinsDisplay.coinCount -= 8;
            mleko = 1;
        }
        
    }
    
    public void kupiTortu()
    {
        if (torta == 1)
        {
            return;
        }
        
        
        if (svecice == 1 && slag == 1 && secer ==1 && jaja == 1 && brasno == 1 && mleko == 1)
        {
            torta = 1;
            if (People.people >= 20)
            {
                SceneManager.LoadScene("KrajUspeh");
            }
        }

    }
}
