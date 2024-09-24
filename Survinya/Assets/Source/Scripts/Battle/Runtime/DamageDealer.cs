using UnityEngine;

// TODO: 接下來實現玩家與敵人身上的血量類別

namespace Source.Battle.Runtime
{
    public interface IDamageDealer
    {
        void DealDamage(int health);
    }

    // TODO: 實現傷害邏輯，預計使用 Service 來處理

    public class PlayerDamageDealer : IDamageDealer
    {
        public void DealDamage(int health)
        {
            Debug.Log($"Take {health} Damage on Player!!");
        }
    }

    public class EnemyDamageDealer : IDamageDealer
    {
        public void DealDamage(int health)
        {
            Debug.Log($"Take {health} Damage on Enemy!!");
        }
    }
}
