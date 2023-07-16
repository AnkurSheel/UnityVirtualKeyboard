using System.Collections.Generic;
using ScriptableObject;
using UnityEngine;
using UnityEngine.UI;

namespace Keyboard
{
    public class VirtualKeyboard : MonoBehaviour
    {
        [SerializeField]
        private string letterOrder = "QWERTYUIOPASDFGHJKLZXCVBNM";

        [SerializeField]
        private GameObject letterContainer;

        [SerializeField]
        private Button deleteButton;

        [SerializeField]
        private Button submitButton;

        private readonly Dictionary<char, KeyboardButton> _letterKeys = new(26);

        [SerializeField]
        private CardSet cardSet;

        private void Start()
        {
            SetupButtons();
        }

        private void SetupButtons()
        {
            SetupLetterKeys();

            deleteButton.onClick.AddListener(() => Debug.Log("Pressed Delete"));

            submitButton.onClick.AddListener(() => Debug.Log("Pressed Enter"));
        }

        private void SetupLetterKeys()
        {
            var keyboardButtons = letterContainer.GetComponentsInChildren<KeyboardButton>();

            for (var i = 0; i < keyboardButtons.Length; i++)
            {
                var letter = letterOrder[i];
                var index = letter - 'A';

                keyboardButtons[i].Setup(cardSet.CardFaces[index], letter);
                _letterKeys[letter] = keyboardButtons[i];
            }
        }
    }
}
