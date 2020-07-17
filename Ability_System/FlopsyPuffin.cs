using UnityEngine;
using System.Collections;

namespace Ability_System
{
    public class FlopsyPuffin : Ability
    {
        [SerializeField] private float _newGravityScale = 1.0f;
        [SerializeField] private FlopsyData _data = null;

        private Rigidbody2D _playerBody = null;
        private float _originalGravityScale = 1.0f;

        public override void UseAbility()
        {
            if (!IsOnCooldown())
            {
                PutOnCooldown();
                Game_Managers.GameManager.Instance.CooldownSystem.PutOnCooldown(_data);
                _playerBody.gravityScale = _newGravityScale;
            }
        }

        private void Start()
        {
            _playerBody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
            _originalGravityScale = _playerBody.gravityScale;
        }

        private void Update()
        {
            if (!Game_Managers.GameManager.Instance.CooldownSystem.IsOnCooldown(_data.ID))
            {
                _playerBody.gravityScale = _originalGravityScale;
            }
        }

        [System.Serializable]
        public class FlopsyData : Cooldown_System.ICooldown
        {
            public int ID => _id;
            public float CooldownDuration => _cooldownDuration;

            [SerializeField] private int _id = 1024;
            [SerializeField] private float _cooldownDuration = 1.0f;
        }
    }
}