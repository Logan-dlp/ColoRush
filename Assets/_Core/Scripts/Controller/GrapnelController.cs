using System;
using System.Collections;
using UnityEngine;

[RequireComponent(
    typeof(CharacterController), 
    typeof(MovementController))]
public class GrapnelController : MonoBehaviour
{
    [SerializeField] private float _grapnelSpeed = 1;
    [SerializeField] private float _distanceStopGrap = 3;
    [SerializeField] private int _distanceToRay = 100;
    
    private CharacterController _characterController;
    private MovementController _movementController;
    private Transform _startPoint;
    
    private Vector3 _characterPosition;
    private Vector3 _hitPoint;
    
    private float _timeLerp;
    private bool _goToHitpoint;
    
    private void Awake()
    {
        _movementController = GetComponent<MovementController>();
        _characterController = GetComponent<CharacterController>();
        _startPoint = GetComponentInChildren<Camera>().transform;

        // a enlever
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (_goToHitpoint)
        {
            _timeLerp += Time.deltaTime * _grapnelSpeed;
            transform.position = Vector3.Lerp(_characterPosition, _hitPoint, Mathf.Clamp01(_timeLerp));
        }

        if (Vector3.Distance(transform.position, _hitPoint) < _distanceStopGrap)
        {
            StopGrap();
        }
    }

    public void Grap()
    {
        if (Physics.Raycast(_startPoint.position, _startPoint.forward, out RaycastHit hit, _distanceToRay))
        {
            _hitPoint = hit.point;
            _characterPosition = transform.position;
            _goToHitpoint = true;
            _movementController.IsLocked = true;
        }
    }

    public void StopGrap()
    {
        if (_goToHitpoint)
        {
            _goToHitpoint = false;
            _movementController.IsLocked = false;
            _timeLerp = 0;
        }
    }
}
