using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Random = UnityEngine.Random;

public class Typer : MonoBehaviour
{
    public BankWords wordBank;
    public TextMeshProUGUI wordOutput;
    public TextMeshProUGUI timerOutput;
    private string preostaleReci = string.Empty;
    private string trenutnaRec = string.Empty;
    private float timeRemaining = 10f;
    private bool isTimerRunning = false;
    private Color originalColor;
    public GameObject karaoke;
    public AudioSource audio1;
   
    public AudioClip src1;
    public AudioClip src2;

    // Start is called before the first frame update
    private void Start()
    {
        originalColor = wordOutput.color;
        SetCurrentWord();
        StartTimer();
    }

    private void SetCurrentWord()
    {
        if (wordBank.HasWordsLeft())  // Check if there are words left
        {
            trenutnaRec = wordBank.getWord();
            SetRemainingWord(trenutnaRec);
        }
        else
        {
            DisplaySuccessMessage();  // Call GameOver when no words are left
        }
    }

    private void SetRemainingWord(string newString)
    {
        preostaleReci = newString;
        wordOutput.text = preostaleReci;
    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();
        UpdateTimer();
    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keyPressed = Input.inputString;

            if (keyPressed.Length == 1)
            {
                EnterLetter(keyPressed);
            }
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if (IsCorrectLetter(typedLetter))
        {
            RemoveLetter();
            if (IsWordComplete())
            {
                SetCurrentWord();
                ResetTimer();
            }
        }
        else
        {
            StartCoroutine(ChangeColorTemporarily(Color.red, 1f));  // Change color to red for 1 second
            
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return preostaleReci.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = preostaleReci.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {
        return preostaleReci.Length == 0;
    }

    private void StartTimer()
    {
        isTimerRunning = true;
        timeRemaining = 10f;
    }

    private void ResetTimer()
    {
        timeRemaining = 10f;
    }

    private void StopTimer()
    {
        isTimerRunning = false;
    }

    private void UpdateTimer()
    {
        if (isTimerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timerOutput.text = timeRemaining.ToString("F2");
            }
            else
            {
                timeRemaining = 0;
                isTimerRunning = false;
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        // End game logic
        StopTimer();
        wordOutput.text = "Game Over!";
        audio1.clip = src2;
        audio1.Play();
        if (karaoke != null)
        {
            karaoke.SetActive(false); // Prikazujemo shop UI kada igrač uđe u trigger
        }
    }

    private void DisplaySuccessMessage()
    {
        // Display success message
        StopTimer();
        wordOutput.text = "Uspešno!";
        audio1.clip = src1;
        audio1.Play();
        int random = Random.Range(1, 5);
        
        People.people += random;
        if (karaoke != null)
        {
            karaoke.SetActive(false); // Prikazujemo shop UI kada igrač uđe u trigger
        }
    }

    private IEnumerator ChangeColorTemporarily(Color newColor, float duration)
    {
        wordOutput.color = newColor;  // Change color to the new color
        yield return new WaitForSeconds(duration);  // Wait for the specified duration
        wordOutput.color = originalColor;  // Change color back to the original color
    }
}
