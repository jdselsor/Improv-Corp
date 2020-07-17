using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collectables
{
    public class CoffeeBean : CollectableItem
    {
        protected override void OnCollected()
        {
            Debug.Log("Coffee Bean Collected");
            Game_Managers.GameManager.Instance.AddBean();
            Destroy(gameObject);
        }
    }
}