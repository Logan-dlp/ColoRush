using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(InputEventButton), menuName = "InputEvent/Button")]
public class InputEventButton : ScriptableObject
{
    public Action Action;

    public void InvokeEvent(InputAction.CallbackContext _ctx)
    {
        if (_ctx.performed)
        {
            Action?.Invoke();
        }
    }
}
