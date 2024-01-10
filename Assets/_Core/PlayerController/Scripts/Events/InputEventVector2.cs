using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "new_" + nameof(InputEventVector2), menuName = "InputEvent/Vector2")]
public class InputEventVector2 : ScriptableObject
{
    public Action<Vector2> MouvementEvent;

    public void InvokeEvent(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            MouvementEvent?.Invoke(ctx.ReadValue<Vector2>());
        }
        else if (ctx.canceled)
        {
            MouvementEvent?.Invoke(Vector2.zero);
        }
    }
}
