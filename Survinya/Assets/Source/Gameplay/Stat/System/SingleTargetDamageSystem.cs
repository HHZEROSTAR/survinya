using Zenject;
using UnityEngine;
using Gameplay.Stat.Mono;

namespace Gameplay.Stat.System
{
    public class SingleTargetDamageSystem : ITickable
    {
        [Inject] private EntityMono targetEntity;

        private float damageAmount   = 10f;
        private float damageInterval = 1f;
        private float lastDamageTime = 0f;

        private Transform damageSource;
        private float     maxDamageDistance = 10f;

        public void Tick()
        {
            if (damageSource == null || targetEntity == null) return;

            if (IsTargetInRange() && Time.time - lastDamageTime >= damageInterval)
            {
                ApplyDamageToTarget();
                lastDamageTime = Time.time;
            }
        }

        private void ApplyDamageToTarget()
        {
            targetEntity.TakeDamage(damageAmount);
        }

        private bool IsTargetInRange()
        {
            return Vector3.Distance(targetEntity.transform.position, damageSource.position) <= maxDamageDistance;
        }

        public void SetDamageSource(Transform newSource)
        {
            damageSource = newSource;
        }

        public void SetTarget(EntityMono newTarget)
        {
            targetEntity = newTarget;
        }

        public void SetDamageAmount(float amount)
        {
            damageAmount = amount;
        }

        public void SetDamageInterval(float interval)
        {
            damageInterval = interval;
        }

        public void SetMaxDamageDistance(float distance)
        {
            maxDamageDistance = distance;
        }
    }
}
