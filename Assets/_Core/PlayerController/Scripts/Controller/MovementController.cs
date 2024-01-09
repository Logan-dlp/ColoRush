using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovementController : MonoBehaviour
{
    private CharacterController _characterController;
    private Vector3 _axisMovement = Vector3.zero;
    
    [SerializeField] private float _speedMovement = 5;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void LateUpdate()
    {
        _characterController.Move(_axisMovement * Time.deltaTime * _speedMovement);
    }

    public void SetAxisMovement(Vector2 axis)
    {
        _axisMovement = new Vector3(axis.x, 0, axis.y);
    }
}
