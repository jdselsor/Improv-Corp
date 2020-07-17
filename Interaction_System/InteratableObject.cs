using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction_System
{
    public abstract class InteratableObject : MonoBehaviour
    {
        public abstract void OnInteraction();
    }
}