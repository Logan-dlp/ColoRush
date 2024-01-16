using System;
using UnityEngine;
using UnityEngine.Events;

public class EventFloatListener : MonoBehaviour
{
    [SerializeField] private EventFloat _eventFloat;
    [SerializeField] private UnityEvent<float> _callbacks;
    [SerializeField] private string _playerPrefName;

    private void OnEnable()
    {
        _eventFloat.ActionFloat += InvokeEvent;
    }

    public void InvokeEvent(float number)
    {
        _callbacks?.Invoke(number);
        PlayerPrefs.SetFloat(_playerPrefName, number);
        PlayerPrefs.Save();
    }
}
