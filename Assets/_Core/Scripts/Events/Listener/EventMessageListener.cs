using UnityEngine;
using UnityEngine.Events;

public class EventMessageListener : MonoBehaviour
{
    [SerializeField] private EventMessage _eventMessage;
    [SerializeField] private UnityEvent _callcaks;

    private void OnEnable()
    {
        _eventMessage.ActionMessage += InvokeEvent;
    }

    public void InvokeEvent()
    {
        _callcaks?.Invoke();
    }
}
