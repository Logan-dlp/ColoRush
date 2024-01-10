using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(InputEventButton), menuName = "InputEvent/Button")]
public class InputEventButton : ScriptableObject
{
    public Action InputAction;

    public void InvokeEvent(InputAction.CallbackContext _ctx)
    {
        if (_ctx.performed)
        {
            InputAction?.Invoke();
        }
    }
}
