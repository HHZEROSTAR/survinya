namespace Gameplay.Stat.Interfaces
{
    public interface IEntity
    {
        int Health { get; }
        int Level  { get; }

        void SetHealth(int health);
        void SetLevel(int level);
    }
}
