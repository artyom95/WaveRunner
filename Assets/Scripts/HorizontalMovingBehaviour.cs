using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HorizontalMovingBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _lenghtMoving;
    [SerializeField]
    private float _durationMoving;
    
    private float _timeMoving;
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = new Vector3(gameObject.transform.position.x - _lenghtMoving,
           0f, 0f);
       _endPosition = new Vector3(gameObject.transform.position.x + _lenghtMoving,
            0f, 0f);
    }
    // Update is called once per frame
    void Update()
    {
        _timeMoving += Time.deltaTime;
        var progress = Mathf.PingPong(_timeMoving, _durationMoving) / _durationMoving;
        transform.position = Vector3.Lerp(_startPosition, _endPosition, progress);
    }
}
