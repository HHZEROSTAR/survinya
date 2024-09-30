using Zenject;
using Gameplay.Stat.Mono;

namespace Gameplay.Stat.System
{
    public class PeriodicEntityDamageSystem : ITickable
    {
        private const string PLAYER_ENTITY_ID = "UNIT_PLAYER_0000";
        private const string ENEMY_ENTITY_ID  = "UNIT_ENEMY_0000";

        [Inject(Id = PLAYER_ENTITY_ID)]
        private EntityMono playerEntity;
        [Inject(Id = ENEMY_ENTITY_ID)]
        private EntityMono enemyEntity;

        private const float TIMER = 1.0f;

        private float elapsedTime = 0.0f;

        public void Tick()
        {
            elapsedTime += UnityEngine.Time.deltaTime;

            if (elapsedTime >= TIMER)
            {
                playerEntity.Health.Value -= 10;
                enemyEntity.Health.Value  -= 10;

                elapsedTime = 0.0f;
            }
        }
    }
}
