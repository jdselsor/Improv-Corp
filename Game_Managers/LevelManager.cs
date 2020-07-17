using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.UI;

namespace Game_Managers
{
    public class LevelManager : MonoBehaviour
    {
        public int CollectedBeans { get; set; } = 0;
        public int CollectedPinkPuffins { get; set; } = 0;
        public int CollectedCoffeeCups { get; set; } = 0;

        [SerializeField] private Text _collectedBeans = null;
        [SerializeField] private Text _allBeans = null;

        [SerializeField] private Image _puffinProgressBar = null;

        private int _totalBeans = 0;
        private int _totalPuffins = 0;
        private int _totalCoffeeCups = 0;

        public void UpdateBeanCount ()
        {
            _collectedBeans.text = CollectedBeans.ToString();

            if (CollectedBeans == Mathf.FloorToInt(_totalBeans / 2))
            {
                _collectedBeans.color = Color.yellow;
            }

            if (CollectedBeans == _totalBeans)
            {
                _collectedBeans.color = Color.green;
            }
        }

        public void UpdatePuffinCount ()
        {
            _puffinProgressBar.fillAmount = ((float)(CollectedPinkPuffins) / _totalPuffins);

            if (CollectedPinkPuffins == Mathf.FloorToInt(_totalPuffins / 2))
            {
                _puffinProgressBar.color = Color.yellow;
            }
            else if (CollectedPinkPuffins == _totalPuffins)
            {
                _puffinProgressBar.color = Color.green;
            }
        }

        public bool CollectedAllPinkPuffins()
        {
            return CollectedPinkPuffins == _totalPuffins;
        }

        private void Start()
        {
            _totalBeans = GameObject.FindGameObjectWithTag("Bean Container").transform.childCount;
            _totalPuffins = GameObject.FindGameObjectWithTag("Pink Puffin Container").transform.childCount;
            _totalCoffeeCups = GameObject.FindGameObjectWithTag("Coffee Cup Container").transform.childCount;

            _allBeans.text = _totalBeans.ToString();

            _puffinProgressBar.fillAmount = ((float) (CollectedPinkPuffins) / _totalPuffins);
        }
    }
}