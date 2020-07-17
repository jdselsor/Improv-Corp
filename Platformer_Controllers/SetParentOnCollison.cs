using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer_Controllers
{
    public class SetParentOnCollison : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.tag.Equals("Player"))
            {
                collision.collider.transform.SetParent(transform);
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.collider.tag.Equals("Player"))
            {
                collision.collider.transform.SetParent(null);
            }
        }
    }
}