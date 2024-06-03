using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


[RequireComponent(typeof(TMP_Text))]
public class WorldTimeDisplay : MonoBehaviour
{
    [SerializeField]
    private WorldTIme _worldTime;
    private TMP_Text _Text;
    private TMP_Text text2;
    

    private void Awake()
    {
        _Text = GetComponent<TMP_Text>();
        _worldTime.WorldTimeChanged += OnWorldTImeChanged;

    }
    private void OnDestroy()
    {
        _worldTime.WorldTimeChanged -= OnWorldTImeChanged;
    }
    private void OnWorldTImeChanged(object sender, TimeSpan newTime)
    {
        _Text.SetText(newTime.ToString(@"hh\:mm"));
    }
}