using Zenject;
using Gameplay.Stat.Core;
using Gameplay.Stat.Services;
using Gameplay.Stat.Interfaces;

namespace GameplayTest.Stat.Installer
{
    public class StatInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IEntityLocator>().To<EntityLocator>().AsSingle();
            Container.Bind<IStatsService>().To<StatsService>().AsSingle();
        }
    }
}
