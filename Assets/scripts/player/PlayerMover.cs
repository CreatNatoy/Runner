using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight; 
    [SerializeField] private Game _gameSpeed;
    [SerializeField] private Joystick _joystick; 

    private Rigidbody2D _rigidbody2D;

    private Vector3 _targetPosition;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate()
    {
        /* 
          if ((Input.GetAxis("Vertical") > 0 && transform.position.y < _maxHeight) || (Input.GetAxis("Vertical") < 0 && transform.position.y > _minHeight))
             _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, Input.GetAxis("Vertical") * _gameSpeed.getSpeedGame);
         else
             _rigidbody2D.velocity = Vector2.zero; 
        */
       
        if ((_joystick.Vertical > 0 && transform.position.y < _maxHeight) || (_joystick.Vertical < 0 && transform.position.y > _minHeight))
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _joystick.Vertical * _gameSpeed.getSpeedGame);
        else
            _rigidbody2D.velocity = Vector2.zero;
    }



    /*
    private void Start()
    {
        _targetPosition = transform.position; 
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _gameSpeed.getSpeedGame * Time.deltaTime);
        }
    }

    public void TryMoveUp()
    {
        if(_targetPosition.y < _maxHeight)
        SetNextPosition(_stepSize);
    }

    public void TryMoveDown()
    {
        if (_targetPosition.y > _minHeight)
            SetNextPosition(-_stepSize);
    }

    private void SetNextPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
    }
     */

}
