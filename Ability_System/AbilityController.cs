using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ability_System
{
    public class AbilityController : MonoBehaviour
    {
        private SlimPuffin _slimPuffin = null;
        private FlopsyPuffin _flopsyPuffin = null;
        private HypocritePuffin _hypocritePuffin = null;

        private void Start()
        {
            _slimPuffin = GetComponent<SlimPuffin>();
            _flopsyPuffin = GetComponent<FlopsyPuffin>();
            _hypocritePuffin = GetComponent<HypocritePuffin>();

            Game_Managers.GameManager.Instance.Controls.Gameplay.Use_Ability_1.performed += _ =>
            {
                _slimPuffin.UseAbility();
            };

            Game_Managers.GameManager.Instance.Controls.Gameplay.Use_Ability_2.performed += _ =>
            {
                _flopsyPuffin.UseAbility();
            };

            Game_Managers.GameManager.Instance.Controls.Gameplay.Use_Ability_3.performed += _ =>
            {
                _hypocritePuffin.UseAbility();
            };

            Game_Managers.GameManager.Instance.Controls.Gameplay.Use_Ability_4.performed += _ =>
            {
                
            };
        }
    }
}