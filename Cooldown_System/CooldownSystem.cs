using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooldown_System
{
    public class CooldownSystem : MonoBehaviour
    {
        private readonly List<CooldownData> cooldowns = new List<CooldownData>();

        public void PutOnCooldown (ICooldown cooldown)
        {
            cooldowns.Add(new CooldownData(cooldown));
        }

        public bool IsOnCooldown (int id)
        {
            foreach (CooldownData cooldown in cooldowns)
            {
                if (cooldown.ID == id)
                {
                    return true;
                }
            }

            return false;
        }

        public float GetRemainingDuration (int id)
        {
            foreach (CooldownData cooldown in cooldowns)
            {
                if (cooldown.ID != id)
                {
                    continue;
                }

                return cooldown.RemainingTime;
            }

            return 0.0f;
        }

        private void Update()
        {
            ProcessCooldowns();
        }

        private void ProcessCooldowns()
        {
            float deltaTime = Time.deltaTime;

            for (int i = cooldowns.Count - 1; i >= 0; i--)
            {
                if (cooldowns[i].DecrementCooldown(deltaTime))
                {
                    cooldowns.RemoveAt(i);
                }
            }
        }
    }

    public class CooldownData
    {
        public int ID { get; }
        public float RemainingTime { get; private set; }

        public CooldownData (ICooldown coolDown)
        {
            ID = coolDown.ID;
            RemainingTime = coolDown.CooldownDuration;
        }

        public bool DecrementCooldown (float deltaTime)
        {
            RemainingTime = Mathf.Max(RemainingTime - deltaTime, 0f);

            return RemainingTime == 0;
        }
    }
}