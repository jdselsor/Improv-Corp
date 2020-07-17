using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Input
{
    public class PlayerInputControl : MonoBehaviour
    {
        [SerializeField] private float _runSpeed = 40.0f;

        private Platformer_Controllers.PlatformerController2D _controller;
        private float horizontalMove = 0f;
        private bool _jump = false;
        private bool _crouch = false;

        private PlayerControls _controls;

        private void Start()
        {
            _controller = GetComponent<Platformer_Controllers.PlatformerController2D>();

            _controls = Game_Managers.GameManager.Instance.Controls;

            _controls.Gameplay.Movement.performed += action => horizontalMove = action.ReadValue<Vector2>().x * _runSpeed;
            _controls.Gameplay.Movement.canceled += _ => horizontalMove = 0;

            _controls.Gameplay.Jump.performed += _ => _jump = true;

            _controls.Gameplay.Crouch.performed += _ => _crouch = true;
            _controls.Gameplay.Crouch.canceled += _ => _crouch = false;
        }

        private void FixedUpdate()
        {
            _controller.Move(horizontalMove * Time.fixedDeltaTime, _crouch, _jump);

            _jump = false;
        }

        /*private void OnEnable()
        {
            _controls.Enable();
        }

        private void OnDisable()
        {
            _controls.Disable();
        }*/
    }
}