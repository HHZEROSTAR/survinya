using Zenject;
using Survinya.Stats.Core;

namespace Survinya.Stats.Tests.Installer
{
    public class StatsInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ActorRegistry>().AsSingle();
            Container.Bind(typeof(IActorSpatial)).To<ActorSpatial>().AsSingle(); // 處理空間相關（如搜尋最近的敵人）的功能
            Container.Bind(typeof(IActorService)).To<ActorService>().AsSingle();
        }
    }
}
