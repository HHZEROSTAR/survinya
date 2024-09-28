using Zenject;

namespace Gameplay.Battle.Core
{
    public interface IHealthBarUpdater
    {
        void UpdateUI();
    }

    // TODO: 目前的邏輯只是 DEMO 用，離能實戰還有段路要走
    // 假設未來有很多敵人需要顯示血條呢?
    
    public class PlayerHealthBarUpdater : IHealthBarUpdater
    {
        [Inject(Id = "UITextPlayerHP")]
        private UnityEngine.UI.Text playerHpText;

        [Inject] private IPlayerHealth playerHealth;

        public void UpdateUI()
        {
            playerHpText.text = playerHealth.GetHealth().ToString();
        }
    }

    public class EnemyHealthBarUpdater : IHealthBarUpdater
    {
        [Inject(Id = "UITextEnemyHP")]
        private UnityEngine.UI.Text enemyHpText;

        [Inject] private IEnemyHealth enemyHealth;

        public void UpdateUI()
        {
            enemyHpText.text = enemyHealth.GetHealth().ToString();
        }
    }
}
