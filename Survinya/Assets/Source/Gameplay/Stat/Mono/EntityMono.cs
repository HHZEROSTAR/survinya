using Zenject;
using UnityEngine;
using Gameplay.Stat.Core;
using Gameplay.Stat.Interfaces;

namespace Gameplay.Stat.Mono
{
    public class EntityMono : MonoBehaviour, IEntity
    {
        [SerializeField] private int m_InitialHealth = 100;
        [SerializeField] private int m_InitialLevel  = 1;

        [Inject] private IStatsService statService;

        private EntityState state;

        public int     MaxHealth => state.MaxHealth;
        public int     Health    => state.CurrentHealth;
        public int     Level     => state.CurrentLevel;

        private void Awake()
        {
            state = new EntityState
            {
                MaxHealth      = m_InitialHealth,
                CurrentHealth  = m_InitialHealth,
                CurrentLevel   = m_InitialLevel,
            };
        }

        public void TakeDamage(int damage)
        {
            statService.ApplyDamage(this, damage);
        }

        public void LevelUp()
        {
            statService.LevelUp(this);
        }

        public void SetHealth(int health) => state.CurrentHealth = health;
        public void SetLevel(int level) => state.CurrentLevel = level;
    }
}
