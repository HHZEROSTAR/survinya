using Zenject;
using Gameplay.Stat.Init;
using Gameplay.Stat.System;

namespace GameplayTest.Stat.Installer
{
    public class DamageZoneSystemInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind(typeof(IInitializable)).To<EntityInit>().AsSingle();
            // Container.Bind<DamageZoneManager>().AsSingle();
            Container.Bind(typeof(ITickable)).To<AreaOfEffectDamageSystem>().AsSingle();
        }
    }
}
