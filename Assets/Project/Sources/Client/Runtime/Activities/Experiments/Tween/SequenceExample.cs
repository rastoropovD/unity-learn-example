using Client.Runtime.Framework;
using DG.Tweening;
using UnityEngine;

namespace Client.Runtime
{
    public class SequenceExample : ButtonCommand
    {
        [SerializeField] private Transform _target;

        public override void Execute()
        {
            Sequence mySequence = DOTween.Sequence();
            mySequence.Append(_target.DOMove(new Vector3(0, 5, 0), 1));
            mySequence.Append(_target.DOScale(new Vector3(2, 2, 2), 1));
            mySequence.Append(_target.DORotate(new Vector3(0, 180, 0), 1));
        }
    }
}