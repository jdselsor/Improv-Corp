using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering;

namespace Game_Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance {get; private set;}

        public Input.PlayerControls Controls { get; private set; } = null;
        public Light2D Sun { get; private set; } = null;

        public bool GamePaused { get; private set; } = false;
        public bool ShowPhone { get; private set; } = false;

        public Checkpoint_System.Checkpoint CurrentCheckpoint { get; private set; } = null;

        public Cooldown_System.CooldownSystem CooldownSystem { get; private set; } = null;

        [SerializeField] private GameObject _pauseMenu = null;
        [SerializeField] private GameObject _phoneMenu = null;
        [SerializeField] private Phone_System.PhoneController _phoneController = null;
        
        private Dialogue_System.DialogueManager _dialogueManager = null;
        
        private Checkpoint_System.Checkpoint[] _checkpoints = new Checkpoint_System.Checkpoint[0];

        private LevelManager _levelManager;

        public void StartDialogue (Dialogue_System.Dialogue[] script)
        {
            _dialogueManager.StartDialogue(script);
        }

        public void ActivateCheckpoint (int checkpoint)
        {
            for (var i = 0; i < _checkpoints.Length; i++)
            {
                _checkpoints[i].ActivatedCheckpoint = false;
            }

            _checkpoints[checkpoint].ActivatedCheckpoint = true;
            CurrentCheckpoint = _checkpoints[checkpoint];
        }

        public void RespawnPlayer ()
        {
            var _player = GameObject.FindGameObjectWithTag("Player");
            var _livesSystem = _player.GetComponent<Lives_System.PlayerLives>();

            _livesSystem.TakeDamage();

            if (_livesSystem.Lives > 0 && CurrentCheckpoint != null)
            {
                _player.transform.position = CurrentCheckpoint.transform.position;
            }
            else if (_livesSystem.Lives > 0)
            {
                _player.transform.position = GameObject.FindGameObjectWithTag("Player Origin").transform.position;
            }
            else
            {
                // Game over
            }
        }

        public bool CollectedAllPuffins ()
        {
            return _levelManager.CollectedAllPinkPuffins();
        }

        // TODO MOve this into a seperate class in the beta "update".
        #region "UI Functionality"
        public void PauseGame ()
        {
            if (_pauseMenu != null)
            {
                _pauseMenu.SetActive(true);
                Time.timeScale = 0.0f;
                GamePaused = true;
            }
        }

        public void ResumeGame ()
        {
            if (_pauseMenu != null)
            {
                _pauseMenu.SetActive(false);
                Time.timeScale = 1.0f;
                GamePaused = false;
            }
        }

        public void ShowPhoneMenu()
        {
            if (_phoneMenu != null)
            {
                Controls.Gameplay.Disable();
                Controls.Dialogue_Menu.Disable();
                Controls.Phone_Menu.Enable();

                _phoneMenu.SetActive(true);
                Time.timeScale = 0.0f;
                ShowPhone = true;
            }
        }

        public void HidePhoneMenu()
        {
            if (_phoneMenu != null)
            {
                if (_phoneController != null)
                {
                    _phoneController.ClosePhoneMenu();
                }

                _phoneMenu.SetActive(false);
                Time.timeScale = 1.0f;
                ShowPhone = false;
            }
        }
        #endregion

        public void AddBean ()
        {
            _levelManager.CollectedBeans += 1;
            _levelManager.UpdateBeanCount();
        }

        public void AddPinkPuffin ()
        {
            _levelManager.CollectedPinkPuffins += 1;
            _levelManager.UpdatePuffinCount();
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;

                Sun = GameObject.FindGameObjectWithTag("Sun").GetComponent<Light2D>();
                CooldownSystem = GetComponent<Cooldown_System.CooldownSystem>();

                SetupControls();
                SetupCheckpoints();

                _dialogueManager = GetComponent<Dialogue_System.DialogueManager>();
                _levelManager = GetComponent<LevelManager>();

                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void SetupCheckpoints()
        {
            var checkpointObjects = GameObject.FindGameObjectsWithTag("Checkpoint");
            _checkpoints = new Checkpoint_System.Checkpoint[checkpointObjects.Length];

            for (var i = 0; i < _checkpoints.Length; i++)
            {
                _checkpoints[i] = checkpointObjects[i].GetComponent<Checkpoint_System.Checkpoint>();

                if (_checkpoints[i] != null)
                {
                    _checkpoints[i].ActivatedCheckpoint = false;
                    _checkpoints[i].CheckpointID = i;
                    _checkpoints[i].transform.name = "Checkpoint " + i.ToString();
                }
            }
        }

        private void SetupControls ()
        {
            Controls = new Input.PlayerControls();

            Controls.Gameplay.Pause_Menu.performed += _ =>
            {
                if (GamePaused)
                {
                    ResumeGame();
                }
                else
                {
                    PauseGame();
                }
            };

            Controls.Gameplay.Open_Phone.performed += _ =>
            {
                if (ShowPhone)
                {
                    HidePhoneMenu();
                }
                else
                {
                    ShowPhoneMenu();
                }
            };

            Controls.Gameplay.Debug_Respawn.performed += _ =>
            {
                if (CurrentCheckpoint != null)
                {
                    GameObject.FindGameObjectWithTag("Player").transform.position = CurrentCheckpoint.transform.position;
                }
            };

            Controls.Gameplay.Debug_Damage.performed += _ =>
            {
                var _liveSystem = GameObject.FindGameObjectWithTag("Player").GetComponent<Lives_System.PlayerLives>();
                if (_liveSystem != null)
                {
                    _liveSystem.TakeDamage();
                    RespawnPlayer();
                }
            };
        }

        private void OnEnable()
        {
            Controls.Enable();

            Controls.Gameplay.Enable();

            Controls.Dialogue_Menu.Disable();
            Controls.Phone_Menu.Disable();
        }

        private void OnDisable()
        {
            Controls.Disable();

            Controls.Gameplay.Disable();
            Controls.Dialogue_Menu.Disable();
            Controls.Phone_Menu.Disable();
        }
    }
}