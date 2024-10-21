using System;
using ModestTree;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Runtime.MVP
{
    public sealed class UiComponentsView : MonoBehaviour
    {
        public event Action<string> OnValueSubmitted; 
        
        [SerializeField] private Button m_button = default;
        [SerializeField] private TMP_InputField m_input = default;

        private const int MinSymbols = 3;
        
        private void Awake()
        {
            Assert.IsNotNull(m_button);
            Assert.IsNotNull(m_input);
            
            m_button.onClick.AddListener(ButtonClicked);
            m_input.onValueChanged.AddListener(OnInputValueChanged);
        }
        
        private void ButtonClicked()
        {
            OnValueSubmitted?.Invoke(m_input.text);
            m_input.text = string.Empty;
        }

        private void OnInputValueChanged(string value)
        {
            m_button.interactable = value.Length >= MinSymbols;
        }
        
        private void OnDestroy()
        {
            m_button.onClick.RemoveListener(ButtonClicked);
            m_input.onValueChanged.RemoveListener(OnInputValueChanged);
        }
    }
}