using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Interaction_System
{
    public class DialogueInteractionObject : InteratableObject
    {
        [SerializeField] private Dialogue_System.Dialogue[] _script = { };

        public override void OnInteraction()
        {
            Game_Managers.GameManager.Instance.StartDialogue(_script);
        }
    }
}