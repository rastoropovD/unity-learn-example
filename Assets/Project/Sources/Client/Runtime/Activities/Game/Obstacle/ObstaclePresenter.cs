using System;
using Client.Runtime.Framework;
using UnityEngine;
using UnityEngine.Assertions;
using Zenject;

namespace Client.Runtime
{
    public sealed class ObstaclePresenter : MonoPresenter
    {
        [SerializeField] private ObstacleView _obstacleView;

        private void Awake()
        {
            Assert.IsNotNull(_obstacleView);
        }

        public override void Enable()
        {
            base.Enable();
        }

        public override void Disable()
        {
            Destroy(_obstacleView.gameObject);
        }
    }
}