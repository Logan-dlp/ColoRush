using System;
using UnityEngine;
using UnityEngine.Events;

public class InputEventVector2Listener : MonoBehaviour
{
    [SerializeField] private InputEventVector2 inputEventVector2;
    [SerializeField] private UnityEvent<Vector2> _callbacks;

    private void OnEnable()
    {
        inputEventVector2.MouvementEvent += InvokeEvent;
    }

    public void InvokeEvent(Vector2 axis)
    {
        _callbacks?.Invoke(axis);
    }
}
