using Gameplay.Battle.Core;

namespace Gameplay.Battle.Mono
{
    public class EnemyDamageCue : DamageCue
    {
        protected override void ResolveDamageDealer()
        {
            damageDealer = container.Resolve<EnemyDamageDealer>();
            healthBarUpdater = container.Resolve<EnemyHealthBarUpdater>();
        }
    }
}
