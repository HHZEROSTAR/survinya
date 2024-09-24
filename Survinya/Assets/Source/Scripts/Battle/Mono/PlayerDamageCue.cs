using Source.Battle.Runtime;

namespace Source.Battle.Mono
{
    public class PlayerDamageCue : DamageCue
    {
        protected override void ResolveDamageDealer()
        {
            damageDealer = container.Resolve<PlayerDamageDealer>();
        }
    }
}
