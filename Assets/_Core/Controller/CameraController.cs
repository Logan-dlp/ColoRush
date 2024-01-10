using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector2 _axisMovement = Vector2.zero;
    private float _rotationY;
    private float _rotationX;
    
    [SerializeField] private float _cameraClamp;
    [SerializeField] private float _sensibility;

    private void Update()
    {
        // The camera takes the position of the movement, and the movement takes the rotation Y of the camera.
        _rotationY -= _axisMovement.x * _sensibility;
        _rotationX += _axisMovement.y * _sensibility;

        _rotationX = Mathf.Clamp(_rotationX, -_cameraClamp, _cameraClamp);
        
        transform.parent.rotation = Quaternion.Euler(0, -_rotationY, 0);
        transform.localRotation = Quaternion.Euler(-_rotationX, 0, 0);
    }

    public void SetAxisMovement(Vector2 axis)
    {
        _axisMovement = axis;
    }
}
