using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collectables
{
    public class PinkPuffin : CollectableItem
    {
        protected override void OnCollected()
        {
            Game_Managers.GameManager.Instance.AddPinkPuffin();
            Destroy(gameObject);
        }
    }
}