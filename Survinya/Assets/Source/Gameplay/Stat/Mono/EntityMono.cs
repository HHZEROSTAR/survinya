using Zenject;
using UnityEngine;
using Gameplay.Stat.Core;
using Gameplay.Stat.Interfaces;
using System.Collections.Generic;

namespace Gameplay.Stat.Mono
{
    public class EntityMono : MonoBehaviour, IEntity
    {
        [SerializeField] private int m_InitialHealth = 100;
        [SerializeField] private int m_InitialLevel = 1;
        [SerializeField] private float m_SearchRadius = 5f;

        [Inject] private IStatsService statService;
        [Inject] private IEntityLocator entityLocator;

        private EntityState state;

        public int MaxHealth => state.MaxHealth;
        public int Health => state.CurrentHealth;
        public int Level => state.CurrentLevel;
        public Vector2 Position => transform.position;
        public float SearchRadius => m_SearchRadius;

        private void Awake()
        {
            state = new EntityState
            {
                MaxHealth = m_InitialHealth,
                CurrentHealth = m_InitialHealth,
                CurrentLevel = m_InitialLevel,
                NearbyEntities = new List<IEntity>()
            };
        }

        public void TakeDamage(int damage)
        {
            statService.ApplyDamage(this, damage);
        }

        public List<IEntity> GetNearbyEntities()
        {
            return entityLocator.GetNearbyEntities(Position, SearchRadius);
        }

        public void LevelUp()
        {
            statService.LevelUp(this);
        }

        public void SetHealth(int health) => state.CurrentHealth = health;
        public void SetLevel(int level) => state.CurrentLevel = level;
    }
}
