using Client.Runtime.Framework;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Runtime
{
    public sealed class ShowSettingsCommand : ButtonCommand
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
            _effect.Append(_fade.DOFade(0.5f, 0.4f));
            _effect.Append(_popUp.DOLocalMove(_destination, 0.5f).SetEase(Ease.InBounce));
            _effect.Pause();
        }

        public override void Execute()
        {
            _popUpObject.SetActive(true);
            _effect.Restart();
        }
    }
}