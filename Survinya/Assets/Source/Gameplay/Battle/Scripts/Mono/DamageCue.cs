using Zenject;
using UnityEngine;
using Gameplay.Battle.Core;

namespace Gameplay.Battle.Mono
{
    public abstract class DamageCue : MonoBehaviour
    {
        [Inject] protected private DiContainer container;

        protected private IDamageDealer     damageDealer;
        protected private IHealthBarUpdater healthBarUpdater;

        protected virtual void Awake()
        {
            ResolveDamageDealer();
        }

        protected abstract void ResolveDamageDealer();

        public void TakeDamage(int health)
        {
            if (damageDealer != null)
            {
                damageDealer.DealDamage(health);
                healthBarUpdater.UpdateUI();
            }
            else
            {
                Debug.LogError("damageDealer 尚未被解析！");
            }
        }
    }
}
