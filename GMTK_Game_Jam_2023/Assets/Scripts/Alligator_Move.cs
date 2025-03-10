using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alligator_Move : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;
    [SerializeField] private float _checkDistance = 0.05f;

    private Transform _targetWaypoint;
    private int _currentWaypointIndex;

    // Start is called before the first frame update
    void Start()
    {
        _targetWaypoint = _waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetWaypoint.position, _speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, _targetWaypoint.position) < _checkDistance)
        {
            _targetWaypoint = GetNextWaypoint();
            SpriteRenderer sprite = GetComponent<SpriteRenderer>();
            sprite.flipX = !sprite.flipX;
        }
    }

    private Transform GetNextWaypoint()
    {
        _currentWaypointIndex++;

        if(_currentWaypointIndex >= _waypoints.Length)
        {
            _currentWaypointIndex = 0;
        }

        return _waypoints[_currentWaypointIndex];
    }
}
