using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(EventBool), menuName = "Event/Bool")]
public class EventBool : ScriptableObject
{
    public Action<bool> ActionBool;
    public bool IsTrue { get; set; }

    public void InvokeEvent()
    {
        ActionBool?.Invoke(IsTrue);
        IsTrue = !IsTrue;
    }
}
