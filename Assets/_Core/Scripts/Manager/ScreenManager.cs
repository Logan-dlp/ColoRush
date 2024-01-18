using System;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private Vector2 _screenResolution;
    [SerializeField] private FullScreenMode _fullScreenMode;
    [SerializeField] private bool _cursorIsLocked;

    private void Awake()
    {
        UpdateResolutionScreen(_screenResolution);
        UpdateCusorLockedMode(_cursorIsLocked);
    }

    public void UpdateResolutionScreen(Vector2 newResolution)
    {
        Screen.SetResolution((int)_screenResolution.x, (int)_screenResolution.y, _fullScreenMode);
    }

    public void UpdateCusorLockedMode(bool isLocked)
    {
        if (isLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
