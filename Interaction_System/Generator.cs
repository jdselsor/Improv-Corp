using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction_System
{
    public class Generator : InteratableObject
    {
        [SerializeField] private float _lightIncreasePercent = 0.25f;

        private bool _interactedWith = false;

        public override void OnInteraction()
        {
            if (!_interactedWith)
            {
                Game_Managers.GameManager.Instance.Sun.intensity += _lightIncreasePercent;
                _interactedWith = true;
            }
        }
    }
}