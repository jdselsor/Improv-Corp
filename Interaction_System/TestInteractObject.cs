using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction_System
{

    public class TestInteractObject : InteratableObject
    {
        [SerializeField] [TextArea(3, 10)] private string _message = "";

        public override void OnInteraction()
        {
            Debug.Log(_message);
        }
    }
}