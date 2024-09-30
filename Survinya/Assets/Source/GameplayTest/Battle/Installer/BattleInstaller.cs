using Zenject;
using Gameplay.Battle.Core;

namespace GameplayTest.Battle.Installer
{
    public class BattleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerDamageDealer>().AsTransient();
            Container.Bind<EnemyDamageDealer>().AsTransient();

            Container.Bind<IPlayerHealth>().To<PlayerHealth>().AsSingle();
            Container.Bind<IEnemyHealth>().To<EnemyHealth>().AsSingle();

            Container.Bind<PlayerHealthBarUpdater>().AsTransient();
            Container.Bind<EnemyHealthBarUpdater>().AsTransient();
        }
    }
}
