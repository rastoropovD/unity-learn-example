using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Assertions;

namespace Client.Runtime
{
    public sealed class SquareTweenExperiments : MonoBehaviour
    {
        [SerializeField] private Transform _square;
        [SerializeField] private Transform _squareToJump;

        private void Awake()
        {
            Assert.IsNotNull(_square);
            Assert.IsNotNull(_squareToJump);
        }

        private void Start()
        {
            TweenerCore<Quaternion, Vector3, QuaternionOptions> rotate = _square
                .DORotate(new Vector3(0, 0, 360), 10, RotateMode.FastBeyond360)
                .SetLoops(-1, LoopType.Incremental)
                .Play();

            Sequence jumpTween = _squareToJump
                .DOLocalJump(new Vector3(0, 300, 0), 30, 1, 5)
                .SetEase(Ease.InOutBounce)
                .SetLoops(-1, LoopType.Restart)
                .Play();

        }
    }
}