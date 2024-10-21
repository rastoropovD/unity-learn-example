using Client.Runtime.MVP;
using Zenject;

namespace Client.Runtime
{
    public sealed class Installer : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<UiComponentsModel>()
                .AsSingle();
        }
    }
}