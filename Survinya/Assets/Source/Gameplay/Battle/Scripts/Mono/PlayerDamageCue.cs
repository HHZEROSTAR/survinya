using Gameplay.Battle.Core;

namespace Gameplay.Battle.Mono
{
    public class PlayerDamageCue : DamageCue
    {
        protected override void ResolveDamageDealer()
        {
            damageDealer = container.Resolve<PlayerDamageDealer>();
            healthBarUpdater = container.Resolve<PlayerHealthBarUpdater>();
        }
    }
}
