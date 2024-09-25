using Source.Gameplay.Battle.Core;

namespace Source.Gameplay.Battle.Mono
{
    public class EnemyDamageCue : DamageCue
    {
        protected override void ResolveDamageDealer()
        {
            damageDealer = container.Resolve<EnemyDamageDealer>();
        }
    }
}
