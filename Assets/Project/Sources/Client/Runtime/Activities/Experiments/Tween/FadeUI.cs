using Client.Runtime.Framework;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Runtime
{
    public class FadeUI : ButtonCommand
    {
        [SerializeField] private Image _image;
        public float fadeDuration = 1f;

        public override void Execute()
        {
            // Fade out the CanvasGroup over 1 second
            _image.DOFade(0, fadeDuration);
        }
    }
}