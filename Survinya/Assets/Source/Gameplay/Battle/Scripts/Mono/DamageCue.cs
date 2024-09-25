using Source.Gameplay.Battle.Core;
using UnityEngine;
using Zenject;

namespace Source.Gameplay.Battle.Mono
{
    public abstract class DamageCue : MonoBehaviour
    {
        [Inject] protected DiContainer container;

        protected private IDamageDealer damageDealer;

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
            }
            else
            {
                Debug.LogError("damageDealer 尚未被解析！");
            }
        }
    }
}
