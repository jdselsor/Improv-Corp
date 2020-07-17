using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO make work with rigidbodys.
namespace Platformer_Controllers
{
    public class MovingPlatformController : MonoBehaviour
    {
        [SerializeField] private GameObject _platform = null;
        [SerializeField] private float _moveSpeed = 5.0f;
        [SerializeField] private Transform[] _waypoints = { };

        private Transform _currentWaypoint = null;

        private int _waypointIndex = 0;

        private void Start()
        {
            _currentWaypoint = _waypoints[_waypointIndex];
            _platform.transform.position = _currentWaypoint.position; // Sets the platform to the frist waypoint
        }

        private void Update()
        {
            _platform.transform.position = Vector3.MoveTowards(_platform.transform.position, _currentWaypoint.position, _moveSpeed * Time.deltaTime);

            if (_platform.transform.position == _currentWaypoint.position)
            {
                _waypointIndex++;

                if (_waypointIndex >= _waypoints.Length)
                {
                    _waypointIndex = 0;
                }

                _currentWaypoint = _waypoints[_waypointIndex];
            }
        }
    }
}