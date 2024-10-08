using System.Collections.Generic;
using Survinya.Stats.Mono;

namespace Survinya.Stats.Core
{
    public class ActorRegistry
    {
        private readonly List<IActor> _actors = new List<IActor>();

        public void Register(IActor actor)
        {
            _actors.Add(actor);
        }

        public void Unregister(IActor actor)
        {
            _actors.Remove(actor);
        }

        public List<IActor> GetActors()
        {
            return _actors;
        }
    }
}
