using Zenject;

namespace Gameplay.Battle.Core
{
    public interface IDamageDealer
    {
        void DealDamage(int damage);
    }

    // TODO: 實現傷害邏輯，預計使用 Service 來處理
    // 現階段沒有使用 Service 是因為對象都足夠簡單
    // 未來如果扯上工廠的話，一些中介層就有必要了
    // 以及其他複雜的架構需要重新思考

    public class PlayerDamageDealer : IDamageDealer
    {
        [Inject] private IPlayerHealth playerHealth;

        public void DealDamage(int damage)
        {
            playerHealth.SetHealth(playerHealth.GetHealth() - damage);
        }
    }

    public class EnemyDamageDealer : IDamageDealer
    {
        [Inject] private IEnemyHealth enemyHealth;

        public void DealDamage(int damage)
        {
            enemyHealth.SetHealth(enemyHealth.GetHealth() - damage);
        }
    }
}
