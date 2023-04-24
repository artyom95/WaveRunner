using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _currentPosition;
    [SerializeField]
    private float _durationMoving;
    [SerializeField] 
    private float _scaleSize;
    [SerializeField] 
    private bool _increase = false;
    [SerializeField] 
    private bool _shrink = false;

    private float _timeMoving;
    private Vector3 _startPosition;
    private Vector3 _endPosition;
   
    private void Awake()
    {
        _startPosition = _currentPosition.localScale;
        if (_increase)
        {
            _endPosition = new Vector3(_currentPosition.localScale.x + _scaleSize,
                _currentPosition.localScale.y + _scaleSize, _currentPosition.localScale.z + _scaleSize);
        }
        if (_shrink)
        {
            _endPosition = new Vector3(_currentPosition.localScale.x - _scaleSize,
                _currentPosition.localScale.y - _scaleSize, _currentPosition.localScale.z - _scaleSize);
        }
    }

    // Update is called once per frame
   private void Update()
    {
        _timeMoving += Time.deltaTime;
        var progress = Mathf.PingPong(_timeMoving, _durationMoving) / _durationMoving;
       transform.localScale = Vector3.Lerp(_startPosition, _endPosition, progress);

    }
}
