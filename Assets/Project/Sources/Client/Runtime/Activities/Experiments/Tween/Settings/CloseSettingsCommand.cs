using Client.Runtime.Framework;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Runtime
{
    public sealed class CloseSettingsCommand : ButtonCommand
    {
        [SerializeField] private GameObject _popUpObject;
        [SerializeField] private Image _fade;
        [SerializeField] private Transform _popUp;

        [SerializeField] private Vector3 _destination;
        private Sequence _effect;
        
        protected override void Awake()
        {
            base.Awake();
            _effect = DOTween.Sequence();
            _effect.Append(_popUp.DOLocalMove(_destination, 0.5f).SetEase(Ease.OutBounce));
            _effect.Append(_fade.DOFade(0, 1f));
            _effect.Pause();
        }

        public override void Execute()
        {
            _effect.Restart();
            _popUpObject.SetActive(false);
        }
    }
}