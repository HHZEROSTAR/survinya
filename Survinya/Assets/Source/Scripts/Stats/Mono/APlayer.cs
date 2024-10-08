using System.Collections.Generic;

namespace Survinya.Stats.Mono
{
    public class APlayer : Actor
    {
        public override ActorType actorType => ActorType.Player;

        protected override void InitializeState()
        {
            base.InitializeState();
            state.CurrentHealth = 150;
            state.MaxHealth = 150;
            state.CurrentLevel = 1;
            state.MaxLevel = 10;
            state.CurrentExperience = 0;
            state.MaxExperience = 100;
        }

        protected override void OnEnable()
        {
            actor.Register(this);
        }

        protected override void OnDisable()
        {
            actor.Unregister(this);
        }

        protected override void Update()
        {
            base.Update();
        }

        protected override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            // TODO: Implement player death
        }

        protected override void OnDeath()
        {
            base.OnDeath();
            // TODO: Implement after player death
        }

        protected override void GainExperience(int experience)
        {
            base.GainExperience(experience);
        }

        protected override void LevelUp()
        {
            base.LevelUp();
        }

        protected override void OnMaxLevel()
        {
            base.OnMaxLevel();
        }

        protected override IActor GetPlayer()
        {
            return null; // Don't need to find the player actor
        }

        protected override IActor GetNearestEnemy()
        {
            return actor.GetNearestActor(this);
        }

        protected override List<IActor> GetNearbyEnemies()
        {
            return actor.GetNearbyActors(this, 1f); // Unused for now
        }
    }
}
