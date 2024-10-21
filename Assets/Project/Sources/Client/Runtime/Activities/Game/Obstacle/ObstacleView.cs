using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace Client.Runtime
{
    public sealed class ObstacleView : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidBody;
        [SerializeField] private RectTransform _transform;
        private Vector2 _movementVector;
        private float _obstacleSpeed = 150;
        Rect screenBounds = new Rect(0f, 0f, Screen.width, Screen.height);

        private void Awake()
        {
            Assert.IsNotNull(_rigidBody);
        }

        private void Update()
        {
            Debug.LogError(IsVisible());
        }

        private void FixedUpdate()
        {
            _movementVector = Vector2.left * Time.deltaTime * _obstacleSpeed;
            _rigidBody.MovePosition(_rigidBody.position + _movementVector);
        }

        public bool IsVisible()
        {
            Vector3[] corners = new Vector3[4];
            _transform.GetWorldCorners(corners);

            for (var i = 0; i < corners.Length; i++)
            {
                if (screenBounds.Contains(corners[i]))
                {
                    return true;
                }
            }
            return false;
        }
        
        private void OnBecameInvisible()
        {
            Debug.LogError("ObstacleView became invisible");
        }
        
        private void OnBecameVisible()
        {
            Debug.LogError("ObstacleView became visible");
        }
    }
}