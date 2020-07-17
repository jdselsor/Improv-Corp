using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon_System
{
    public class LaserSword : MonoBehaviour, Cooldown_System.ICooldown
    {
        public int ID => _id;
        public float CooldownDuration => _coolDownDuration;
        public float Range => _range;

        [SerializeField] private int _id = 0;
        [SerializeField] private float _coolDownDuration = 1.0f;
        [SerializeField] private float _range = 2.0f;

        [SerializeField] private Transform _firePoint = null;
        [SerializeField] private LayerMask _enemyLayer = LayerMask.GetMask();

        public void UseWeapon()
        {
            if (Game_Managers.GameManager.Instance.CooldownSystem.IsOnCooldown(ID))
            {
                return;
            }
            Debug.Log("Used Laser Sword");

            Game_Managers.GameManager.Instance.CooldownSystem.PutOnCooldown(this);

            Debug.DrawRay(_firePoint.position, (_firePoint.parent.localScale.x > 0 ? Vector2.right : -Vector2.right) * Range, Color.red, 1.0f);
            RaycastHit2D hit = Physics2D.Raycast(_firePoint.position, (_firePoint.parent.localScale.x > 0 ? Vector2.right : -Vector2.right), Range, _enemyLayer);

            if (hit.collider != null)
            {

            }
        }
    }
}