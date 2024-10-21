using Client.Runtime.Framework;
using DG.Tweening;
using UnityEngine;

namespace Client.Runtime
{
    public class RotateObject : ButtonCommand
    {
        [SerializeField] private Transform _target;
        public Vector3 endRotation = new Vector3(0, 180, 0);
        public float duration = 2f;

        public override void Execute()
        {
            // Rotate the object to 180 degrees over 2 seconds
            _target.DORotate(endRotation, duration);
        }
    }
}