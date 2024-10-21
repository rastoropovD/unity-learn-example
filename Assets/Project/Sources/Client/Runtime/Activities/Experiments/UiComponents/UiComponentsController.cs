using System;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace Client.Runtime
{
    public sealed class UiComponentsController : MonoBehaviour
    {
        
        [SerializeField] private Button m_button = default;
        [SerializeField] private TMP_InputField m_input = default;
        [SerializeField] private TextMeshProUGUI m_text = default;

        private const int MinSymbols = 3;
        
        private void Awake()
        {
            Assert.IsNotNull(m_button);
            Assert.IsNotNull(m_input);
            Assert.IsNotNull(m_text);
            
            m_button.onClick.AddListener(ButtonClicked);
            m_input.onValueChanged.AddListener(OnInputValueChanged);
        }

        private void ButtonClicked()
        {
            m_text.text = m_input.text;
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