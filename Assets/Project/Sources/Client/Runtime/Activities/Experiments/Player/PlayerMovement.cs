using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace Client.Runtime
{
    public sealed class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rb;
        
        private void Awake()
        {
            Assert.IsNotNull(_rb, "[PlayerMovement] Rigidbody2D is required");
            Debug.Log($"transform position: {_rb.mass}");
        }

        private void Update()
        {
            
        }
    }
}