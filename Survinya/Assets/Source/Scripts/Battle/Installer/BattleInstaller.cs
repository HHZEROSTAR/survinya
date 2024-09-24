using Zenject;
using Source.Battle.Runtime;

namespace Source.Battle.Installer
{
    public class BattleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerDamageDealer>().AsTransient();
            Container.Bind<EnemyDamageDealer>().AsTransient();
        }
    }
}
