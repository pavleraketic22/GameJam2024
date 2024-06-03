using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class WorldTIme : MonoBehaviour
{
    public event EventHandler<TimeSpan> WorldTimeChanged;


    [SerializeField]
    private float _dayLength;
    public  TimeSpan _currentTime;
    public static int vreme = -1;
    public static int dani = 1;
    private float _minuteLength => _dayLength / WorldTimeConstant.MinuteInDay;

    private void Start()
    {
        StartCoroutine(AddMinute());
    }
    private IEnumerator AddMinute()
    {
        _currentTime += TimeSpan.FromMinutes(1)/5;
        vreme = _currentTime.Hours;
        if (vreme == 23)
        {
            dani++;
        }

        if (dani == 6)
        {
            SceneManager.LoadScene("KrajNeuspeh");
        }
        WorldTimeChanged?.Invoke(this, _currentTime);   
        yield return new WaitForSeconds(_minuteLength);
        StartCoroutine(AddMinute());
    }
    
    
}