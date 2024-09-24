using Source.Battle.Runtime;

namespace Source.Battle.Mono
{
    public class EnemyDamageCue : DamageCue
    {
        protected override void ResolveDamageDealer()
        {
            damageDealer = container.Resolve<EnemyDamageDealer>();
        }
    }
}
