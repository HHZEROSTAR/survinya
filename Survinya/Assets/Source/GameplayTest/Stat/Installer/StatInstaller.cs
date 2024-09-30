using Zenject;
using Gameplay.Stat.Init;

namespace GameplayTest.Stat.Installer
{
    public class StatInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInitializable>().To<EntityInit>().AsSingle();
        }
    }
}
