using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lives_System
{
    public class PlayerLives : MonoBehaviour
    {
        public int Lives { get; private set; }
        public event System.Action OnDeath;

        [SerializeField] private int _startingLives = 3;

        public void AddLive ()
        {
            Lives += 1;
            Debug.Log(Lives.ToString());
        }

        public void TakeDamage()
        {
            Lives -= 1;

            if (Lives <= 0)
            {
                Debug.Log("The player has no lives");
                if (OnDeath != null)
                {
                    OnDeath();
                }

                Destroy(gameObject);
            }
        }

        private void Start()
        {
            Lives = _startingLives;
        }
    }
}