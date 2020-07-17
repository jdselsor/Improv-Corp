using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Weapon_System
{
    public class WeaponController : MonoBehaviour
    {
        public bool UsePhoneLaser { get; set; } = false;

        private LaserSword _sword = null;
        private PhoneLaser _phoneLaser = null;

        private void Start()
        {
            _sword = GetComponent<LaserSword>();
            _phoneLaser = GetComponent<PhoneLaser>();

            Game_Managers.GameManager.Instance.Controls.Gameplay.Attack.performed += ctx => 
            {
                Debug.Log(UsePhoneLaser.ToString());

                if (UsePhoneLaser)
                {
                    // Do phone laser
                    _phoneLaser.UseWeapon();
                }
                else
                {
                    _sword.UseWeapon();
                }
            };

            Game_Managers.GameManager.Instance.Controls.Gameplay.Debug_Full_Ammo.performed += _ =>
            { 
                if (_phoneLaser != null)
                {
                    _phoneLaser.AddShot(_phoneLaser.GetTotalShots());
                }
            };
        }
    }
}