using Source.Gameplay.Battle.Core;

namespace Source.Gameplay.Battle.Mono
{
    public class PlayerDamageCue : DamageCue
    {
        protected override void ResolveDamageDealer()
        {
            damageDealer = container.Resolve<PlayerDamageDealer>();
        }
    }
}
