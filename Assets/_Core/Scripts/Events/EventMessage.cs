using System;
using UnityEngine;

[CreateAssetMenu(fileName = "new_" + nameof(EventMessage), menuName = "Event/Message")]
public class EventMessage : ScriptableObject
{
    public Action ActionMessage;

    public void InvokeEvent()
    {
        ActionMessage?.Invoke();
    }
}
