using UnityEngine;
using System.Collections;
using Collectables;

namespace CollabProxy
{
    public class CoffeeCup : CollectableItem
    {
        protected override void OnCollected()
        {
            var playerLives = GameObject.FindGameObjectWithTag("Player").GetComponent<Lives_System.PlayerLives>();

            if (playerLives != null)
            {
                playerLives.AddLive();
                Destroy(gameObject);
            }
        }
    }
}