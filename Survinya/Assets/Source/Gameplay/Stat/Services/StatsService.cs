using UnityEngine;
using Gameplay.Stat.Interfaces;

namespace Gameplay.Stat.Services
{
    public class StatsService : IStatsService
    {
        public void ApplyDamage(IEntity entity, int damage) => entity.SetHealth(Mathf.Max(0, entity.Health - damage)); // 運算邏輯抽離至核心類別
        public void LevelUp(IEntity entity) => entity.SetLevel(entity.Level + 1);                                      // 運算邏輯抽離至核心類別
    }
}
