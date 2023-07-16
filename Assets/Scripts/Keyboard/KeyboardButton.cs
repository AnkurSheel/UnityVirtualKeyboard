using ScriptableObject;
using UnityEngine;
using UnityEngine.UI;

namespace Keyboard
{
    public class KeyboardButton : Button
    {
        public char Letter { get; private set; }

        public void Setup(CardFace card, char letter)
        {
            image.sprite = card.Image;
            Letter = letter;

            onClick.AddListener(() =>
            {
                Debug.Log($"Clicked {letter}");
            });
        }
    }
}
