using Client.Runtime.Framework;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Runtime
{
    public class ColorChange : ButtonCommand
    {
        [SerializeField] private Image _targetRenderer;
        public Color targetColor = Color.white;
        public float duration = 2f;

        public override void Execute()
        {
            // Change the object's color to red over 2 seconds
            _targetRenderer.DOColor(targetColor, duration);
        }
    }
}