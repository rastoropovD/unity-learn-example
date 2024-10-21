using Client.Runtime.Framework;
using DG.Tweening;
using UnityEngine;

namespace Client.Runtime
{
    public class LoopingTween : ButtonCommand
    {
        [SerializeField] private Transform _target;
        
        public Vector3 endPosition = new Vector3(0, 200, 0);
        public float jumpPower = 20f;
        public float duration = 1f;
        
        public override void Execute()
        { 
            // Move the object up and down forever
            _target.DOLocalJump(
                endPosition,
                jumpPower,
                1,
                duration)
                .SetLoops(-1, LoopType.Restart);
        }
    }
}