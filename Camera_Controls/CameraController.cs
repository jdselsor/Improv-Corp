using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Camera_Controllers
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform _target = null;
        [SerializeField] private Vector3 _offset = new Vector3(0, 0, -10.0f);
        [SerializeField] private float _followSharpness = 0.1f;

        private void LateUpdate()
        {
            if (_target != null)
            {
                float blend = 1.0f - Mathf.Pow(1.0f - _followSharpness, Time.deltaTime * 30.0f);
                transform.position = Vector3.Lerp(transform.position, _target.position + _offset, blend);
            }
        }
    }
}