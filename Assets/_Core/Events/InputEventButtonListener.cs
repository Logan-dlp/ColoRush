using System;
using UnityEngine;
using UnityEngine.Events;

public class InputEventButtonListener : MonoBehaviour
{
    [SerializeField] private InputEventButton _inputEventButton;
    [SerializeField] private UnityEvent _callbacks;
    
    private void OnEnable()
    {
        _inputEventButton.InputAction += InvokeEvent;
    }

    private void OnDisable()
    {
        _inputEventButton.InputAction -= InvokeEvent;
    }

    public void InvokeEvent()
    {
        _callbacks?.Invoke();
    }
}
