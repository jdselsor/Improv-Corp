using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooldown_System
{
    public interface ICooldown
    {
        int ID { get; }
        float CooldownDuration { get; }
    }
}