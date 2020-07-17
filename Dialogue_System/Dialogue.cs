using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dialogue_System
{
    [System.Serializable]
    public class Dialogue
    {
        public string Speaker { get { return _speaker; } }
        public string Line { get { return _line; } }

        [SerializeField] private string _speaker = "";
        [SerializeField][TextArea(3, 10)] private string _line = "";
    }
}