using UnityEngine;
using System.Linq;
using Survinya.Stat.Mono;
using System.Collections.Generic;

namespace Survinya.Stat.Core
{
    public interface IActorSpatial
    {
        List<IActor> GetNearbyActors(IActor self, List<IActor> actors, float searchRadius);
        IActor GetNearestActor(IActor self, List<IActor> actors);
    }

    public class ActorSpatial : IActorSpatial
    {
        public List<IActor> GetNearbyActors(IActor self, List<IActor> actors, float searchRadius)
        {
            return actors
                .Where(actor => Vector2.Distance(self.Position, actor.Position) <= searchRadius)
                .ToList();
        }

        public IActor GetNearestActor(IActor self, List<IActor> actors)
        {
            return actors
                .OrderBy(actor => Vector2.Distance(self.Position, actor.Position))
                .FirstOrDefault();
        }
    }
}
