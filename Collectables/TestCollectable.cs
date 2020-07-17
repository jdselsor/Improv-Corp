using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collectables
{
    public class TestCollectable : CollectableItem
    {
        [SerializeField][TextArea(3, 10)] private string _message = "";

        protected override void OnCollected()
        {
            Debug.Log(_message);
            Destroy(gameObject);
        }
    }
}