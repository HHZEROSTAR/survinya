using Zenject;
using UnityEngine;
using System.Collections.Generic;
using Gameplay.Stat.Mono;

namespace Gameplay.Stat.System
{
    public class AreaOfEffectDamageSystem : ITickable
    {
        [Inject] private List<EntityMono> allEntities;

        private float damageAmount   = 10f;
        private float damageInterval = 1f;
        private float lastDamageTime = 0f;

        private Transform        damageSource;
        private float            damageZoneRadius = 5f;
        private List<EntityMono> targetsInZone    = new List<EntityMono>();

        public void Tick()
        {
            if (damageSource == null) return;

            UpdateTargetsInZone();

            if (Time.time - lastDamageTime >= damageInterval)
            {
                ApplyDamageToTargets();
                lastDamageTime = Time.time;
            }
        }

        private void UpdateTargetsInZone()
        {
            targetsInZone.Clear();
            foreach (var entity in allEntities)
            {
                if (IsEntityInDamageZone(entity))
                {
                    targetsInZone.Add(entity);
                }
            }
        }

        private void ApplyDamageToTargets()
        {
            foreach (var target in targetsInZone)
            {
                target.TakeDamage(damageAmount);
            }
        }

        private bool IsEntityInDamageZone(EntityMono entity)
        {
            return Vector3.Distance(entity.transform.position, damageSource.position) <= damageZoneRadius;
        }

        public void SetDamageSource(Transform newSource)
        {
            damageSource = newSource;
        }

        public void SetDamageAmount(float amount)
        {
            damageAmount = amount;
        }

        public void SetDamageInterval(float interval)
        {
            damageInterval = interval;
        }

        public void SetDamageZoneRadius(float radius)
        {
            damageZoneRadius = radius;
        }
    }
}
