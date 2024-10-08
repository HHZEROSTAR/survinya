using System.Collections.Generic;

namespace Survinya.Stats.Mono
{
    public class AEnemy : Actor
    {
        public override ActorType actorType => ActorType.Enemy;

        protected override void InitializeState()
        {
            base.InitializeState();
            state.MaxHealth = 10;
            state.CurrentHealth = 10;
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
            // TODO: Implement enemy death
        }

        protected override void OnDeath()
        {
            base.OnDeath();
            // TODO: Implement after enemy death
        }

        protected override void GainExperience(int experience)
        {
            // Don't need to gain experience for the enemy
        }

        protected override void LevelUp()
        {
            // Don't need to level up the enemy
        }

        protected override void OnMaxLevel()
        {
            // Don't need to do anything when the enemy reaches max level
        }

        protected override IActor GetPlayer()
        {
            return actor.GetPlayer();
        }

        protected override IActor GetNearestEnemy()
        {
            return null; // Don't need to find the nearest enemy
        }

        protected override List<IActor> GetNearbyEnemies()
        {
            return null; // Don't need to find nearby enemies
        }
    }
}
