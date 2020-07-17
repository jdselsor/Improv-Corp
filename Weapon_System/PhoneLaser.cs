using UnityEngine;
using System.Collections;

namespace Weapon_System
{
    public class PhoneLaser : MonoBehaviour, Cooldown_System.ICooldown
    {
        public int ID => _id;
        public float CooldownDuration => _coolDownDuration;
        public float Range => _range;
        public int ShotsInChamber { get; private set; }

        [SerializeField] private int _id = 0;
        [SerializeField] private float _coolDownDuration = 1.0f;
        [SerializeField] private float _range = 2.0f;

        [SerializeField] private Transform _firePoint = null;
        [SerializeField] private LayerMask _enemyLayer = LayerMask.GetMask();
        [SerializeField] private int _totalShots = 5;

        public int GetTotalShots ()
        {
            return _totalShots;
        }

        public void AddShot (int amount)
        {
            ShotsInChamber += amount;

            if (ShotsInChamber > _totalShots)
            {
                ShotsInChamber = _totalShots;
            }
        }

        public void UseWeapon()
        {
            if (Game_Managers.GameManager.Instance.CooldownSystem.IsOnCooldown(ID) && ShotsInChamber > 0)
            {
                return;
            }

            Debug.Log("Used Phone Laser");

            Game_Managers.GameManager.Instance.CooldownSystem.PutOnCooldown(this);
            ShotsInChamber -= 1;

            Debug.DrawRay(_firePoint.position, (_firePoint.parent.localScale.x > 0 ? Vector2.right : -Vector2.right) * Range, Color.green, 1.0f);
            RaycastHit2D hit = Physics2D.Raycast(_firePoint.position, (_firePoint.parent.localScale.x > 0 ? Vector2.right : -Vector2.right), Range, _enemyLayer);

            if (hit.collider != null)
            {

            }
        }

        private void Start()
        {
            ShotsInChamber = _totalShots;
        }
    }
}