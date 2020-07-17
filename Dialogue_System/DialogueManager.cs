using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

namespace Dialogue_System
{
    public class DialogueManager : MonoBehaviour
    {
        [SerializeField] private GameObject _dialogueContainer = null;
        [SerializeField] private Text _speakerText = null;
        [SerializeField] private Text _lineText = null;

        private Queue<Dialogue> _script = null;

        public void Start()
        {
            if (Game_Managers.GameManager.Instance.Controls != null)
            {
                Game_Managers.GameManager.Instance.Controls.Dialogue_Menu.Procide_Dialogue.performed += _ =>
                {
                    DisplayNextSentence();
                };
            }

            _script = new Queue<Dialogue>();
        }

        public void StartDialogue (Dialogue[] dialogue)
        {
            if (_script != null)
            {
                _dialogueContainer.SetActive(true);

                Game_Managers.GameManager.Instance.Controls.Gameplay.Disable();
                Game_Managers.GameManager.Instance.Controls.Phone_Menu.Disable();
                Game_Managers.GameManager.Instance.Controls.Dialogue_Menu.Enable();

                _script.Clear();

                foreach (Dialogue dialogueItem in dialogue)
                {
                    _script.Enqueue(dialogueItem);
                }
            }

            DisplayNextSentence();
        }

        private void DisplayNextSentence ()
        {
            if (_script.Count == 0)
            {
                EndDialogue();
            }

            var dialogue = _script.Dequeue();

            StopAllCoroutines();

            _speakerText.text = dialogue.Speaker;
            StartCoroutine(TypeLine(dialogue.Line));
        }

        private IEnumerator TypeLine (string line)
        {
            _lineText.text = "";

            foreach (char letter in line.ToCharArray())
            {
                _lineText.text += letter;
                yield return null;
            }
        }

        private void EndDialogue ()
        {
            _dialogueContainer.SetActive(false);

            Game_Managers.GameManager.Instance.Controls.Gameplay.Enable();
            Game_Managers.GameManager.Instance.Controls.Phone_Menu.Disable();
            Game_Managers.GameManager.Instance.Controls.Dialogue_Menu.Disable();
        }
    }
}