using UnityEngine;
using System.Linq;
using Gameplay.Stat.Mono;
using Gameplay.Stat.Interfaces;
using System.Collections.Generic;

namespace Gameplay.Stat.Core
{
    public class EntityLocator : IEntityLocator
    {
        public List<IEntity> GetNearbyEntities(Vector2 position, float radius)
        {
            var allEntityMonos = Object.FindObjectsOfType<EntityMono>();

            return allEntityMonos
                .Where(entity =>
                    Vector2.Distance(entity.Position, position) <= radius &&
                    entity.Position                             != position)
                .Cast<IEntity>()
                .ToList();
        }
    }
}
