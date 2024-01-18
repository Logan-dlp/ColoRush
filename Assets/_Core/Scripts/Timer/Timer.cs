using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> _callbacks;
    
    private float _timer;
    
    private void Update()
    {
        _timer += Time.deltaTime;
        _callbacks?.Invoke(_timer);
    }

    public void StopTime()
    {
        PlayerPrefs.SetFloat("Timer", _timer);
    }
}
