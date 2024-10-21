using System;
using UnityEngine;
using UnityEngine.Assertions;
using Zenject;

namespace Client.Runtime.MVP
{
    public sealed class UiComponentsPresenter : MonoBehaviour
    {
        [SerializeField] private UiComponentsView m_view = default;
        
        [Inject] private readonly UiComponentsModel m_model = default;

        private void Awake()
        {
            Assert.IsNotNull(m_view);

            m_view.OnValueSubmitted += ValueSubmitted;
        }

        private void ValueSubmitted(string value)
        {
            m_model.Value = value;
            Debug.LogError($"m_model.Value: {m_model.Value}");
        }

        private void OnDestroy()
        {
            m_view.OnValueSubmitted -= ValueSubmitted;
        }
    }
}