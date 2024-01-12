using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(InputEventVector2), menuName = "InputEvent/Vector2")]
public class InputEventVector2 : ScriptableObject
{
    public Action<Vector2> Vector2Action;

    public void InvokeEvent(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Vector2Action?.Invoke(ctx.ReadValue<Vector2>());
        }
        else if (ctx.canceled)
        {
            Vector2Action?.Invoke(Vector2.zero);
        }
    }
}
