using Gameplay.Stat.Interfaces;
using System.Collections.Generic;

namespace Gameplay.Stat.Core
{
    public class EntityState
    {
        public int MaxHealth     { get; set; }
        public int CurrentHealth { get; set; }
        public int CurrentLevel  { get; set; }
        public List<IEntity> NearbyEntities { get; set; }
    }
}