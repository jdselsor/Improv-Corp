using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ability_System
{
    [System.Serializable]
    public abstract class Ability : MonoBehaviour, Cooldown_System.ICooldown
    {
        public int ID => _id;
        public string AbilityName => _abilityName;
        public float CooldownDuration => _cooldownDuration;

        [SerializeField] private int _id = 0;
        [SerializeField] private float _cooldownDuration = 2.0f;
        [SerializeField] private string _abilityName = "Ability";

        public abstract void UseAbility();

        protected bool IsOnCooldown ()
        {
            return Game_Managers.GameManager.Instance.CooldownSystem.IsOnCooldown(ID);
        }

        protected void PutOnCooldown()
        {
            Game_Managers.GameManager.Instance.CooldownSystem.PutOnCooldown(this);
        }
    }
}