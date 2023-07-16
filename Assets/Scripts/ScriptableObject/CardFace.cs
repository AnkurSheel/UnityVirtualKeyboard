using UnityEngine;

namespace ScriptableObject
{
    [CreateAssetMenu(fileName = "New CardFace", menuName = "Scriptable Objects/Card Face", order = 0)]
    public class CardFace : UnityEngine.ScriptableObject
    {
        [SerializeField]
        private Sprite image;

        [SerializeField]
        private char letter;

        public Sprite Image => image;
        public char Letter => char.ToUpper(letter);
    }
}
