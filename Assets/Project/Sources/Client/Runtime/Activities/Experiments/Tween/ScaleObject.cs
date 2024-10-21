using Client.Runtime.Framework;
using DG.Tweening;
using UnityEngine;

namespace Client.Runtime
{
    public class ScaleObject : ButtonCommand
    {
        [SerializeField] private Transform _target;
        [SerializeField] private AnimationCurve m_easeCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

        public Vector3 endScale = new Vector3(2, 2, 2);
        public float duration = 1.5f;

        public override void Execute()
        {
            // Scale the object to endScale over 1.5 seconds
            _target.DOScale(endScale, duration)
                // .SetEase(m_easeCurve)
                .SetEase(Ease.InOutBounce);
        }
    }
}