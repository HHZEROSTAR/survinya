namespace Gameplay.Stat.Interfaces
{
    public interface IStatsService
    {
        void ApplyDamage(IEntity entity, int damage);
        void LevelUp(IEntity entity);
    }
}
