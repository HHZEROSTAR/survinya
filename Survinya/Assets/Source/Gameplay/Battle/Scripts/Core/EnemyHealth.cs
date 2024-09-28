namespace Gameplay.Battle.Core
{
    public interface IEnemyHealth
    {
        public int  GetHealth();
        public void SetHealth(int newHealth);
    }

    // TODO: 目前的血量儲存的架構並不正確，雖然可用，但最終應該不會是長這樣
    // 應該考量到大量實例的情況，這樣的架構會有問題

    public class EnemyHealth : IEnemyHealth
    {
        private int health = 100; // TODO: 這裡不應該使用硬編碼，目前只是為了快速迭代而直接寫在這裡

        public int  GetHealth()              => health;
        public void SetHealth(int newHealth) => health = newHealth;
    }
}
