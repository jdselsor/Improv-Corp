using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hazard_System
{
    public class TouchOnKill : MonoBehaviour
    {
        private bool _run = false;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag.Equals("Player") && !_run)
            {
                Game_Managers.GameManager.Instance.RespawnPlayer();
                _run = true;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag.Equals("Player"))
            {
                _run = false;
            }
        }
    }
}