using UnityEngine;
using UnityEngine.UI;

public class TimerDisplayed : MonoBehaviour
{
    public float TimerToDisplayed { get; set; }

    [SerializeField] private Text _text;
    
    private void Update()
    {
        if (TimerToDisplayed < 0)
        {
            TimerToDisplayed = 0;
        }

        float _minutes = Mathf.FloorToInt(TimerToDisplayed / 60);
        float _seconds = Mathf.FloorToInt(TimerToDisplayed % 60);
        float _milliseconds = TimerToDisplayed % 1 * 1000;

        _text.text = string.Format("{0:00}:{1:00}:{2:000}", _minutes, _seconds, _milliseconds);
    }
}
