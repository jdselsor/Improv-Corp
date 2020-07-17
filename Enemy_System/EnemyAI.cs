using Lives_System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

namespace Enemy_System
{
    public class EnemyAI : MonoBehaviour
    {
        public enum AIType { STATIONARY, PATROLER, CHARGER};

        [SerializeField] private float _moveSpeed = 5.0f;
        [SerializeField] private AIType _type = AIType.STATIONARY;

        [SerializeField] private EnemeyAttack _attack = null;
        [SerializeField] private float lifeTime = 5.0f;
        [SerializeField] private EnemyPatrol _patrol = null;

        private Platformer_Controllers.PlatformerController2D _controller;
        private float _horizontalMove = 0.0f;

        private bool _charge = false;

        private void Start()
        {
            _controller = GetComponent<Platformer_Controllers.PlatformerController2D>();
            _patrol.CurrentWaypoint = _patrol.Waypoints[0];
            _controller.transform.position = _patrol.CurrentWaypoint.transform.position;
        }

        private void Update()
        {
            switch (_type)
            {
                case AIType.PATROLER:
                    if (Vector3.Distance(_controller.transform.position, _patrol.CurrentWaypoint.position) < 0.001)
                    {
                        if (!Game_Managers.GameManager.Instance.CooldownSystem.IsOnCooldown(_patrol.ID))
                        {
                            Game_Managers.GameManager.Instance.CooldownSystem.PutOnCooldown(_patrol);
                            _patrol.NextWaypoint();
                            _horizontalMove = (transform.position - _patrol.CurrentWaypoint.position).normalized.x * _moveSpeed;
                        }

                        Attack();
                    }
                    break;
                case AIType.CHARGER:
                    foreach (Transform firePoint in _attack.FirePoints)
                    {
                        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, (_controller.transform.localScale.x > 0 ? Vector2.right : -Vector2.left), _attack.Range, _attack.PlayerMask);
                        if (hit.collider != null)
                        {
                            var player = hit.collider.transform;
                            _horizontalMove = (transform.position - player.position).normalized.x * _moveSpeed;
                            Destroy(gameObject, lifeTime);
                        }
                    }
                    break;
                default:
                    Attack();
                    break;
            }
        }

        private void FixedUpdate()
        {
            switch(_type)
            {
                case AIType.STATIONARY:
                    break;
                case AIType.PATROLER:
                    if (!Game_Managers.GameManager.Instance.CooldownSystem.IsOnCooldown(_patrol.ID))
                    {
                        _controller.Move(_horizontalMove * Time.fixedDeltaTime, false, false);
                    }
                    break;
                default:
                    _controller.Move(_horizontalMove * Time.fixedDeltaTime, false, false);
                    break;
            }
        }

        private void Attack ()
        {
            if (!Game_Managers.GameManager.Instance.CooldownSystem.IsOnCooldown(_attack.ID))
            {
                Game_Managers.GameManager.Instance.CooldownSystem.PutOnCooldown(_attack);
                foreach (Transform firePoint in _attack.FirePoints)
                {
                    RaycastHit2D hit = Physics2D.Raycast(firePoint.position, (_controller.transform.localScale.x > 0 ? Vector2.right : -Vector2.left), _attack.Range, _attack.PlayerMask);
                    if (hit.collider != null)
                    {
                        var playerLives = hit.collider.GetComponent<Lives_System.PlayerLives>();

                        playerLives.TakeDamage();
                        Game_Managers.GameManager.Instance.RespawnPlayer();
                    }
                }
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.transform.tag.Equals("Player"))
            {
                var playerLives = collision.transform.GetComponent<Lives_System.PlayerLives>();

                playerLives.TakeDamage();
                Game_Managers.GameManager.Instance.RespawnPlayer();
            }
        }

        [System.Serializable]
        public class EnemeyAttack : Cooldown_System.ICooldown
        {
            public int ID => _id;
            public float CooldownDuration => _cooldownDuration;
            public float Range => _range;
            public LayerMask PlayerMask => _playerMask;
            public Transform[] FirePoints => _firePoints;

            [SerializeField] private int _id = 5;
            [SerializeField] private float _cooldownDuration = 2.0f;
            [SerializeField] private float _range = 5.0f;
            [SerializeField] private LayerMask _playerMask = LayerMask.GetMask();
            [SerializeField] private Transform[] _firePoints = { };
        }

        [System.Serializable]
        public class EnemyPatrol : Cooldown_System.ICooldown
        {
            public int ID => _id;
            public float CooldownDuration => _cooldownDuration;
            public Transform[] Waypoints => _waypoints;
            public Transform CurrentWaypoint { get; set; } = null;
            public int WaypointIndex => _waypointIndex;

            [SerializeField] private int _id = 0;
            [SerializeField] private float _cooldownDuration = 2.0f;
            [SerializeField] private Transform[] _waypoints = { };
            private int _waypointIndex = 0;

            public void NextWaypoint ()
            {
                _waypointIndex++;

                if (_waypointIndex >= _waypoints.Length)
                {
                    _waypointIndex = 0;
                }

                CurrentWaypoint = _waypoints[_waypointIndex];
            }
        }
    }
}