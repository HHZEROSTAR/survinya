using UniRx;
using Zenject;
using Gameplay.Stat.Mono;

namespace Gameplay.Stat.Init
{
    public class EntityInit : IInitializable
    {
        private const string PLAYER_ENTITY_ID = "UNIT_PLAYER_0000";
        private const string ENEMY_ENTITY_ID  = "UNIT_ENEMY_0000";

        [Inject(Id = PLAYER_ENTITY_ID)]
        private EntityMono playerEntity;
        [Inject(Id = PLAYER_ENTITY_ID)]
        private DebuggerMono playerDebugger;

        [Inject(Id = ENEMY_ENTITY_ID)]
        private EntityMono enemyEntity;
        [Inject(Id = ENEMY_ENTITY_ID)]
        private DebuggerMono enemyDebugger;

        public void Initialize()
        {
            playerEntity.Health.Value = 100;
            enemyEntity.Health.Value  = 100;

            playerEntity.Health
                .Subscribe(health => playerDebugger.SetDebugInfo("Health", health.ToString()))
                .AddTo(playerEntity);

            enemyEntity.Health
                .Subscribe(health => enemyDebugger.SetDebugInfo("Health", health.ToString()))
                .AddTo(enemyEntity);
        }
    }
}
