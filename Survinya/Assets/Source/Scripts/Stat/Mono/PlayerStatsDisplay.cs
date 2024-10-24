using Zenject;
using UnityEngine;
using UnityEngine.UI;

namespace Survinya.Stat.Mono
{
    public class PlayerStatsDisplay : MonoBehaviour
    {
        [SerializeField] private Image m_HealthBar;

        private const string PLAYER_ID = "UNIT_PLAYER";

        [Inject(Id = PLAYER_ID)]
        private APlayer _player;

        private void Update()
        {
            DisplayHealth();
        }

        private void DisplayHealth()
        {
            m_HealthBar.fillAmount = (float)_player.State.CurrentHealth / _player.State.MaxHealth;
        }
    }
}
