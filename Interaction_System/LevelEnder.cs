using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction_System
{
    public class LevelEnder : InteratableObject
    {
        public override void OnInteraction()
        {
            if (Game_Managers.GameManager.Instance.CollectedAllPuffins())
            {
                Debug.Log("You beat the level!");
            }
            else
            {
                Debug.Log("You Didn't beat the level. Find the rest of the puffins!");
            }
        }
    }
}