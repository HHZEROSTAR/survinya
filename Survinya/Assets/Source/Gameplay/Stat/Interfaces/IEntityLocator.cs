using UnityEngine;
using System.Collections.Generic;

namespace Gameplay.Stat.Interfaces
{
    public interface IEntityLocator
    {
        List<IEntity> GetNearbyEntities(Vector2 position, float radius);
    }
}
