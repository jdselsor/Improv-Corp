using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapon_System;

namespace Phone_System
{
    public class PhoneController : MonoBehaviour
    {
        [SerializeField] private GameObject[] _appOverlays = { };
        [SerializeField] private GameObject _phoneLight = null;
        [SerializeField] private Weapon_System.WeaponController _weaponController = null;

        private GameObject _currentOverlay = null;

        public void ClosePhoneMenu ()
        {
            foreach (GameObject appOverlay in _appOverlays)
            {
                _currentOverlay = null;
                appOverlay.SetActive(false);
            }

            Game_Managers.GameManager.Instance.Controls.Gameplay.Enable();
            Game_Managers.GameManager.Instance.Controls.Phone_Menu.Disable();
            Game_Managers.GameManager.Instance.Controls.Dialogue_Menu.Disable();
        }

        public void TooglePhoneLight ()
        {
            if (_phoneLight != null)
            {
                _phoneLight.SetActive(!_phoneLight.activeSelf);
            }
        }

        public void OpenWeaponControlApp ()
        {
            foreach (GameObject appOverlay in _appOverlays)
            {
                if (appOverlay.name.Equals("Weapon Control"))
                {
                    appOverlay.SetActive(true);
                    _currentOverlay = appOverlay;
                }
            }
        }

        public void TogglePhoneLaser ()
        {
            if (_weaponController != null)
            {
                Debug.Log("toggled phone laser");
                _weaponController.UsePhoneLaser = !_weaponController.UsePhoneLaser;
            }
        }

        public void CloseApp ()
        {
            _currentOverlay.SetActive(false);
            _currentOverlay = null;
        }

        private void Start()
        {
            _weaponController = GameObject.FindGameObjectWithTag("Player").GetComponent<WeaponController>();
        }
    }
}