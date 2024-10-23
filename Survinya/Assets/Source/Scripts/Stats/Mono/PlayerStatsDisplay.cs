using Zenject;
using UnityEngine;
using UnityEngine.UI;

namespace Stats.Mono
{
    [RequireComponent(typeof(Text))]
    public class PlayerStatsDisplay : MonoBehaviour
    {
        [SerializeField] private Image m_HealthBar;

        private const string PLAYER_ID = "UNIT_PLAYER";

        [Inject(Id = PLAYER_ID)]
        private EntityMono player;

        private void Update()
        {
            DisplayHealth();
        }

        private void DisplayHealth()
        {
            m_HealthBar.fillAmount = (float)player.Health / player.MaxHealth;
        }
    }

    public class EntityMono
    {
        public float Health { get; set; }
        public float MaxHealth { get; set; }
    }
}
