using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class TriggerEventMessage : MonoBehaviour
{
    [SerializeField] private UnityEvent _callbaks;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out CharacterController characterController))
        {
            _callbaks?.Invoke();
        }
    }
}
