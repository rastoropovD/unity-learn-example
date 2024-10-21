using UnityEngine;
using UnityEngine.Assertions;
using Zenject;

namespace Client.Runtime
{
    public sealed class ObstacleInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _obstaclePrefab;
        
        public override void InstallBindings()
        {
            Assert.IsNotNull(_obstaclePrefab);
            
            
        }
    }
}