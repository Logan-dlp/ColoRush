using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ApplySaveSettingsValue : MonoBehaviour
{
    [SerializeField] private EventFloat _eventFloat;
    [SerializeField] private string _playerPrefName;
    
    private void Start()
    {
        _eventFloat.InvokeEvent(PlayerPrefs.GetFloat(_playerPrefName, 100));
    }
}
