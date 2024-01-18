using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputSetPause : MonoBehaviour
{ 
    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    public void SetActionMapUi(bool isActive)
    {
        if (isActive)
        {
            _playerInput.SwitchCurrentActionMap("UI");
            Time.timeScale = 0;
        }
        else
        {
            _playerInput.SwitchCurrentActionMap("Game");
            Time.timeScale = 1;
        }
    }
}
