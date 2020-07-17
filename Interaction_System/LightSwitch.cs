using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

namespace Interaction_System
{
    public class LightSwitch : InteratableObject
    {
        [SerializeField] private Light2D _light = null;
        [SerializeField] private bool _canToggle = true;

        [Tooltip("Controls how dark the level should get 0 is complete darkness and 1 is no darkness.")]
        [SerializeField] private float _darknessValue = 0.01f; // This is how dark the level is to get.

        private bool _toggled = false;
        private float _lightIntesity = 0.0f;

        public override void OnInteraction()
        {
            if (_light != null)
            {
                if (_canToggle)
                {
                    _light.intensity = (_toggled ? _darknessValue : _lightIntesity);
                    _toggled = !_toggled;
                }
                else
                {
                    if (!_toggled)
                    {
                        _light.intensity = 0.0f;
                        _toggled = true;
                    }
                }
            }
        }

        private void Start()
        {
            _lightIntesity = _light.intensity;
        }
    }
}