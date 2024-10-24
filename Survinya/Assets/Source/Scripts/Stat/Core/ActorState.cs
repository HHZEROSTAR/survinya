namespace Survinya.Stat.Core
{
    public class ActorState
    {
        public int CurrentHealth { get; internal set; }
        public int MaxHealth { get; internal set; }
        public int CurrentExperience { get; internal set; }
        public int MaxExperience { get; internal set; }
        public int CurrentLevel { get; internal set; }
        public int MaxLevel { get; internal set; }
    }
}
