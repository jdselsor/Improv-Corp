using UnityEngine;
using System.Collections;
using System;

namespace Ability_System
{
    [System.Serializable]
    public class SlimPuffin : Ability
    {
        [SerializeField] private GameObject _puffinToSpawn = null;
        [SerializeField] private float _pufflinLifeTime = 5.0f;
        [SerializeField] private Transform _firePoint = null;
        [SerializeField] private Vector3 _offset = Vector3.right;

        public override void UseAbility()
        {
            if (!IsOnCooldown())
            {
                //(_firePoint.parent.localScale.x > 0 ? Vector2.right : -Vector2.right)
                PutOnCooldown();
                var clone = Instantiate(_puffinToSpawn, (_firePoint.parent.localScale.x > 0 ? _offset : -_offset) + _firePoint.position, transform.rotation);
                Destroy(clone, _pufflinLifeTime);
            }
        }
    }
}