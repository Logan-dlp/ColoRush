using UnityEngine;
using UnityEngine.Events;

public class ApplySaveSettingsValue : MonoBehaviour
{
    [SerializeField] private EventFloat _eventFloat;
    [SerializeField] private string _playerPrefName;
    [SerializeField] private float _defaltValue;
    
    private void Start()
    {
        _eventFloat.InvokeEvent(PlayerPrefs.GetFloat(_playerPrefName, _defaltValue));
    }
}
