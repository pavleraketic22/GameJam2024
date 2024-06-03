using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class BankWords : MonoBehaviour
{
    private List<string> originalnaRec = new List<string>()
    {
        "O majko stara" , "nista nije isto", "U sto kafana", "proslo", "mi", "detinjstvo"
    };
    
    private List<string> workingWords = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        workingWords.AddRange(originalnaRec);
        ConverToLower(workingWords);
        // Shafle(workingWords); // If you want to shuffle the words
    }

    private void Shafle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];
            list[i] = list[random];
            list[random] = temporary;
        }
    }

    private void ConverToLower(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string getWord()
    {
        string newWord = string.Empty;
        if (workingWords.Count != 0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }
        return newWord;
    }

    public bool HasWordsLeft()
    {
        return workingWords.Count > 0;
    }

    public int GetTotalWords()
    {
        return originalnaRec.Count;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}