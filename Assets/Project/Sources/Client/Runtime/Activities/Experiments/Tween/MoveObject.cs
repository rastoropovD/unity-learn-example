using Client.Runtime.Framework;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Client.Runtime
{
    public class MoveObject : ButtonCommand
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Vector3 _targetPosition = new Vector3(0, 5, 0);
        [SerializeField] private float _duration = 2f;

        private TweenerCore<Vector3, Vector3, VectorOptions> _effect;

        protected override void Awake()
        {
            base.Awake();
            // Move the object to targetPosition over 2 seconds
            _effect = _target.DOLocalMove(_targetPosition, _duration).SetAutoKill(false).Pause();
        }

        public override void Execute()
        {
            _effect.Restart();
        }
    }
}