using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventBoolListener : MonoBehaviour
{
    [SerializeField] private EventBool _eventBool;
    [SerializeField] private UnityEvent<bool> _callbaks;

    private void OnEnable()
    {
        _eventBool.ActionBool += InvokeEvent;
    }

    public void InvokeEvent(bool isTrue)
    {
        _callbaks?.Invoke(isTrue);
    }
}
