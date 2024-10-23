using Survinya.Stat.Mono;
using System.Collections.Generic;

namespace Survinya.Stat.Core
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
