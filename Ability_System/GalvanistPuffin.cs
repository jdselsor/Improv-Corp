using UnityEngine;
using System.Collections;

namespace Ability_System
{
    public class GalvanistPuffin : Ability
    {
        [SerializeField] private LayerMask _powerLayer = LayerMask.GetMask();
        [SerializeField] private Transform _player = null;
        [SerializeField] private float _interactRadius = 5.0f;

        public override void UseAbility()
        {
            if (!IsOnCooldown())
            {
                PutOnCooldown();
                var powerableObjects = Physics2D.OverlapCircleAll(_player.position, _interactRadius, _powerLayer);
                // TODO do the power interactions.
            }
        }

        private void Start()
        {
            _player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}