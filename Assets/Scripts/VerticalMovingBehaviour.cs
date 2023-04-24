using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingBehaviour : MonoBehaviour
{
    [SerializeField]
    private Vector3 _startPosition;
    [SerializeField]
    private Vector3 _endPosition;
    [SerializeField]
    private float _durationMoving;

    private float _timeMoving;
   // Update is called once per frame
    void Update()
    {
        _timeMoving += Time.deltaTime;
        var progress = Mathf.PingPong(_timeMoving, _durationMoving) / _durationMoving;
        transform.position = Vector3.Lerp(_startPosition,_endPosition,progress);
    }
}
