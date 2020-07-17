using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collectables
{
    public abstract class CollectableItem : MonoBehaviour
    {
        private bool _run = false;

        protected abstract void OnCollected();

        protected virtual void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.tag.Equals("Player") && !_run)
            {
                _run = true;
                OnCollected();
            }
        }
    }
}