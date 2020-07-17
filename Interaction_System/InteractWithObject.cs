using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction_System
{
    public class InteractWithObject : MonoBehaviour
    {
        [SerializeField] private LayerMask _interactionMask = LayerMask.GetMask();
        [SerializeField] private float _interactWithRadius = 5.0f;

        private Input.PlayerControls _controls = null;

        private void Start()
        {
            _controls = Game_Managers.GameManager.Instance.Controls;

            _controls.Gameplay.Interact.started += _ => GetInteractables();
        }

        // TODO: Rename this.
        private void GetInteractables()
        {
            var interactableCollider = Physics2D.OverlapCircle(transform.position, _interactWithRadius, _interactionMask);
            //interactable.GetComponent<InteratableObject>().OnInteraction();

            if (interactableCollider != null)
            {
                var interactables = interactableCollider.GetComponents<InteratableObject>();

                if (interactables != null)
                {
                    foreach (InteratableObject obj in interactables)
                    {
                        obj.OnInteraction();
                    }
                }
            }
        }
    }
}