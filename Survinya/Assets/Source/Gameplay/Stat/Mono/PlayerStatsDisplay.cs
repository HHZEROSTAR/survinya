using Zenject;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Stat.Mono
{
    [RequireComponent(typeof(Text))]
    public class PlayerStatsDisplay : MonoBehaviour
    {
        [SerializeField] private Image m_HealthBar;
        [SerializeField] private Text  m_HealthText;

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
            m_HealthText.text      = $"{player.Health} / {player.MaxHealth}";
        }
    }
}
