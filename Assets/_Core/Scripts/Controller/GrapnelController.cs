using System;
using System.Collections;
using UnityEngine;

[RequireComponent(
    typeof(CharacterController), 
    typeof(MovementController),
    typeof(LineRenderer))]
public class GrapnelController : MonoBehaviour
{
    [SerializeField] private float _grapnelSpeed = 1;
    [SerializeField] private float _distanceStopGrap = 3;
    [SerializeField] private int _distanceToRay = 100;
    
    private CharacterController _characterController;
    private MovementController _movementController;
    private LineRenderer _lineRenderer;
    private Transform _startPoint;
    
    private Vector3 _characterPosition;
    private Vector3 _hitPoint;
    private Vector3[] _linePosition = new Vector3[2];
    
    private float _timeLerp;
    private bool _goToHitpoint;
    
    private void Awake()
    {
        _movementController = GetComponent<MovementController>();
        _characterController = GetComponent<CharacterController>();
        _startPoint = GetComponentInChildren<Camera>().transform;
        
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        _lineRenderer.alignment = LineAlignment.View;

        // a enlever
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (_goToHitpoint)
        {
            _timeLerp += Time.deltaTime * _grapnelSpeed;
            transform.position = Vector3.Lerp(_characterPosition, _hitPoint, Mathf.Clamp01(_timeLerp));
            
            _linePosition[0] = transform.position;
            _linePosition[1] = _hitPoint;
            _lineRenderer.SetPositions(_linePosition);
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

            _linePosition[0] = _linePosition[1];
            _lineRenderer.SetPositions(_linePosition);
        }
    }
}
