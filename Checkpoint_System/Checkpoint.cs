using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Checkpoint_System
{
    public class Checkpoint : MonoBehaviour
    {
        public bool ActivatedCheckpoint { get; set; } = false;
        public int CheckpointID { get; set; } = 0;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag.Equals("Player") && !ActivatedCheckpoint)
            {
                Debug.Log("Set Checkpoint");

                Game_Managers.GameManager.Instance.ActivateCheckpoint(CheckpointID);
            }
        }
    }
}