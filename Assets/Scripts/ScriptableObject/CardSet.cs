using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObject
{
    [CreateAssetMenu(fileName = "New CardSet", menuName = "Scriptable Objects/Card Set", order = 0)]
    public class CardSet : UnityEngine.ScriptableObject
    {
        [SerializeField]
        private List<CardFace> cardFaces;

        public IReadOnlyList<CardFace> CardFaces => cardFaces;
    }
}
