using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction_System
{
    public class SwitchObjectState : InteratableObject
    {
        [SerializeField] private GameObject _object = null;
        [SerializeField] private bool _canToggle = true;

        private bool _toggled = false;

        public override void OnInteraction()
        {
            if (_object != null)
            {
                if (_canToggle)
                {
                    _object.SetActive(!_object.activeSelf);
                }
                else
                {
                    if (!_toggled)
                    {
                        _object.SetActive(!_object.activeSelf);
                        _toggled = true;
                    }
                }
            }
        }
    }
}