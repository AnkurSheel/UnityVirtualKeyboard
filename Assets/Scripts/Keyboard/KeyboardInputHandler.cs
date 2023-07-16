using System.Linq;
using ScriptableObject;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Keyboard
{
    public class KeyboardInputHandler : MonoBehaviour
    {
        [SerializeField]
        private CardSet cardSet;

        private void OnEnable()
        {
            // Enable keyboard input
            InputSystem.EnableDevice(UnityEngine.InputSystem.Keyboard.current);
            UnityEngine.InputSystem.Keyboard.current.onTextInput += OnTextInput;
        }

        private void OnDisable()
        {
            // Disable keyboard input
            InputSystem.DisableDevice(UnityEngine.InputSystem.Keyboard.current);
            UnityEngine.InputSystem.Keyboard.current.onTextInput -= OnTextInput;
        }

        private void OnTextInput(char input)
        {
            if (char.IsLetter(input))
            {
                if (cardSet.CardFaces.Any(card => card.Letter == char.ToUpper(input)))
                {
                    Debug.Log($"Key pressed {input}");
                }
            }
            else
            {
                switch (input)
                {
                    case '\n':
                    case '\r':
                        Debug.Log($"Enter pressed");
                        break;
                    case '\b':
                        Debug.Log($"Backspace pressed");
                        break;
                }
            }
        }
    }
}
