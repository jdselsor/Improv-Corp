using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Menu_Controllers
{
    public class MenuManager : MonoBehaviour
    {
        public static MenuManager Instance { get; private set; }

        [SerializeField] private GameObject[] _menus = new GameObject[0];

        // Goes to the a menu screen. Will do logic if it is the level select screen or the options.
        public void GotoScreen (int screen)
        {
            for (var i = 0; i < _menus.Length; i++)
            {
                _menus[i].SetActive(false);
            }

            _menus[screen].SetActive(true);

            switch (screen)
            {
                case 2:
                    SetUpLevelMenu();
                    break;
                case 3:
                    SetUpOptions();
                    break;
            }
        }

        public void QuitApplication ()
        {
            Application.Quit();
        }

        private void SetUpOptions ()
        {

        }

        private void SetUpLevelMenu ()
        {

        }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);

                GotoScreen(0);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}