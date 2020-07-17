using UnityEngine;
using System.Collections;

namespace Ability_System
{
    public class HypocritePuffin : Ability
    {
        [SerializeField] private LayerMask _enemyMask = LayerMask.GetMask();
        [SerializeField] private Transform _firePoint = null;
        [SerializeField] private float _range = 2.5f;

        public override void UseAbility()
        {
            if (!IsOnCooldown())
            {
                PutOnCooldown();

                RaycastHit2D hit = Physics2D.Raycast(_firePoint.position, (_firePoint.parent.localScale.x > 0 ? Vector2.right : -Vector2.right), _range, _enemyMask);

                if (hit.collider != null)
                {

                }
            }
        }

        private void Start()
        {
            _firePoint = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
}