using Zenject;
using Survinya.Stats.Mono;
using System.Collections.Generic;

namespace Survinya.Stats.Core
{
    public interface IActorService
    {
        void Register(IActor actor);
        void Unregister(IActor actor);
        List<IActor> GetActorsWithoutSelf(IActor self);
        List<IActor> GetEnemies();
        List<IActor> GetNearbyActors(IActor self, float searchRadius);
        IActor GetPlayer();
        IActor GetNearestActor(IActor actor);
    }

    public class ActorService : IActorService
    {
        [Inject] private ActorRegistry _actorRegistry;
        [Inject] private IActorSpatial _actorSpatial;

        public void Register(IActor actor)
        {
            _actorRegistry.Register(actor);
        }

        public void Unregister(IActor actor)
        {
            _actorRegistry.Unregister(actor);
        }

        public List<IActor> GetActorsWithoutSelf(IActor self)
        {
            return _actorRegistry.GetActors().FindAll(actor => actor != self);
        }

        public List<IActor> GetEnemies()
        {
            return _actorRegistry.GetActors().FindAll(actor => actor is AEnemy);
        }

        public List<IActor> GetNearbyActors(IActor self, float searchRadius)
        {
            return _actorSpatial.GetNearbyActors(self, GetActorsWithoutSelf(self), searchRadius);
        }

        public IActor GetNearestActor(IActor self)
        {
            return _actorSpatial.GetNearestActor(self, GetActorsWithoutSelf(self));
        }

        public IActor GetPlayer()
        {
            return _actorRegistry.GetActors().Find(actor => actor is APlayer);
        }
    }

    public class ActorRegistry
    {
        public void Register(IActor actor) {}
        public void Unregister(IActor actor) {}
        public List<IActor> GetActors() { return null; }
    }

    public interface IActorSpatial
    {
        List<IActor> GetNearbyActors(IActor self, List<IActor> getActorsWithoutSelf, float searchRadius);
        IActor GetNearestActor(IActor self, List<IActor> getActorsWithoutSelf);
    }
}
