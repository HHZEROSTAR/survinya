using UniRx;
using UnityEngine;
using System.Collections.Generic;

namespace Gameplay.Stat.Mono
{
    public class EntityMono : MonoBehaviour
    {
        private readonly Dictionary<string, object> attributes = new Dictionary<string, object>();

        public void SetAttribute(string key, object value)
        {
            attributes[key] = value;
        }

        public T GetAttribute<T>(string key)
        {
            if (attributes.TryGetValue(key, out var value))
            {
                return (T)value;
            }

            return default(T);
        }

        public ReactiveProperty<int> Health { get; private set; } = new ReactiveProperty<int>(0);

        public void SetAttribute(string attribute, int value)
        {
            if (attribute == "Health")
            {
                Health.Value = value;
            }
        }

        public void TakeDamage(float damage)
        {
            var currentHealth = Health.Value;
            var newHealth     = Mathf.Max(0, currentHealth - Mathf.RoundToInt(damage));
            Health.Value = newHealth;
        }
    }
}
