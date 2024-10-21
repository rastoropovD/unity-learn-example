using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

namespace Client.Runtime
{
    public sealed class ObstaclesController : MonoBehaviour
    {
        [SerializeField] private GameObject _obstaclePrefab;
        [SerializeField] private Transform _groundSpawnPoint;
        
        private readonly List<ObstaclePresenter> _obstaclePresenters = new List<ObstaclePresenter>();
        
        private void Awake()
        {
            Assert.IsNotNull(_obstaclePrefab);
            Assert.IsNotNull(_groundSpawnPoint);
        }

        private void Update()
        {
            
        }
    }
}