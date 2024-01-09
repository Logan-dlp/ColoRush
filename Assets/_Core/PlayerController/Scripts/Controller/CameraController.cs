using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector2 _axisMovement = Vector2.zero;
    private float _rotationY;
    private float _rotationX;
    
    [SerializeField] private MovementController _movementController;
    
    [SerializeField] private float _cameraClamp;
    [SerializeField] private float _sensibility;

    private void LateUpdate()
    {
        // The camera takes the position of the movement, and the movement takes the rotation of the camera.
        transform.position = _movementController.transform.position;
        _movementController.transform.rotation = Quaternion.Euler(_movementController.transform.rotation.x, transform.rotation.y, _movementController.transform.rotation.z);

        _rotationY -= _axisMovement.x * _sensibility;
        _rotationX += _axisMovement.y * _sensibility;

        _rotationX = Mathf.Clamp(_rotationX, -_cameraClamp, _cameraClamp);
        
        transform.rotation = Quaternion.Euler(-_rotationX, -_rotationY, 0);
    }

    public void SetAxisMovement(Vector2 axis)
    {
        Debug.Log(axis);
        _axisMovement = axis;
    }
}
