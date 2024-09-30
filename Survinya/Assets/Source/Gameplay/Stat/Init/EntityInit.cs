using Zenject;
using Gameplay.Stat.Mono;

namespace Gameplay.Stat.Init
{
    public class EntityInit : IInitializable
    {
        [Inject(Id = "UNIT_PLAYER_0000")]
        private EntityMono playerEntity;
        [Inject(Id = "UNIT_PLAYER_0000")]
        private DebuggerMono playerDebugger;

        public void Initialize()
        {
            playerEntity.SetAttribute("Health", 100);
            playerDebugger.SetDebugInfo("Health", "100");
            playerDebugger.SetDebugInfo("Mana", "100");
        }
    }
}
