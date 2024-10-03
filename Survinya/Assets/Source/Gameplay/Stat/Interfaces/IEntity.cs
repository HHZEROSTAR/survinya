using UnityEngine;

namespace Gameplay.Stat.Interfaces
{
    public interface IEntity
    {
        int Health { get; }
        int Level  { get; }
        Vector2 Position     { get; }
        float   SearchRadius { get; }

        void SetHealth(int health);
        void SetLevel(int level);
    }
}
