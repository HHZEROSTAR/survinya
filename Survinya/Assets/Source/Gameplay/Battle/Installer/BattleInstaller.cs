using Zenject;
using Gameplay.Battle.Core;

namespace Gameplay.Battle.Installer
{
    public class BattleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerDamageDealer>().AsTransient();
            Container.Bind<EnemyDamageDealer>().AsTransient();

            Container.Bind<IPlayerHealth>().To<PlayerHealth>().AsSingle();
            Container.Bind<IEnemyHealth>().To<EnemyHealth>().AsSingle();

            Container.Bind<PlayerHealthBarUpdater>().AsTransient();
            Container.Bind<EnemyHealthBarUpdater>().AsTransient();

            // TODO: 目前的結果是血量會不斷扣至負數，這肯定是不正確的
            // 這裡應該會有一個檢查機制，確保血量不會低於 0，並且在血量歸零時觸發死亡事件
            // 死亡可能牽涉到 FSM，不同狀態涉及場景的切換或重置
            // 
            // 關於血量是整數這點，根據某個遊戲開發者的說法
            // 只要牽涉到計算，數值必然應該要設計為整數
            // 並且只在顯示時轉換為浮點數
            // 不只是避免浮點數計算誤差，在未來走 TDD 的時候也會更容易（更容易寫測試）
            //
            // 至於策略模式，目前只有兩種對象，但敵人不會只有一種，這時候就需要考慮到工廠結合策略模式
            // 這樣就可以在不同的敵人類型中使用不同的血量計算方式
            // 目前的寫法都只是很粗糙的做法
            // 這部分需要花較多時間 Study 一些比較穩健的做法，或設計架構的觀念
        }
    }
}
