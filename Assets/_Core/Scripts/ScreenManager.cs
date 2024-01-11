using System;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private Vector2 _screenResolution;
    [SerializeField] private FullScreenMode _fullScreenMode;
    [SerializeField] private CursorLockMode _cursorLockMode;

    private void Start()
    {
        UpdateResolutionScreen(_screenResolution);
        UpdateCusorLockedMode(_cursorLockMode);
    }

    public void UpdateResolutionScreen(Vector2 newResolution)
    {
        Screen.SetResolution((int)_screenResolution.x, (int)_screenResolution.y, _fullScreenMode);
    }

    public void UpdateCusorLockedMode(CursorLockMode cursorLockMode)
    {
        Cursor.lockState = cursorLockMode;
    }
}
