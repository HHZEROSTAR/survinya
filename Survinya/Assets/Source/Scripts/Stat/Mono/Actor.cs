using System;
using Zenject;
using UnityEngine;
using System.Collections;
using Survinya.Stat.Core;
using System.Collections.Generic;
using UniRx;

namespace Survinya.Stat.Mono
{
    public enum ActorType
    {
        Player,
        Enemy,
        DroppedItem,
        Projectile
    }

    public interface IActor
    {
        ActorType actorType { get; }
        Vector2 Position { get; }
        string Name { get; }
        ActorState State { get; }
        bool IsDead { get; set; }
        bool IsInvincible { get; set; }
        bool IsInRange(Vector2 position, float range);
        void TakeDamage(int damage);
    }

    public class Actor : MonoBehaviour, IActor
    {
        [Inject] protected IActorService actor;

        public virtual ActorType actorType { get; protected set; }

        public Vector2 Position => transform.position;
        public string Name => name;
        public ActorState State => state;
        public bool IsDead { get; set; }
        public bool IsInvincible { get; set; }

        public bool IsInRange(Vector2 position, float range)
        {
            return Vector2.Distance(Position, position) <= range;
        }

        protected ActorState state;

        protected virtual void InitializeState()
        {
            state = new ActorState();
        }

        private void Awake()
        {
            InitializeState();
        }

        protected virtual void OnEnable() {}
        protected virtual void OnDisable() {}
        protected virtual void Update() {}

        private int ModifyHealth(int amount)
        {
            state.CurrentHealth = Mathf.Clamp(state.CurrentHealth + amount, 0, state.MaxHealth);
            return state.CurrentHealth;
        }

        private int ModifyExperience(int experience)
        {
            state.CurrentExperience = Mathf.Clamp(state.CurrentExperience + experience, 0, state.MaxExperience);
            return state.CurrentExperience;
        }

        private int ModifyLevel(int level)
        {
            state.CurrentLevel = Mathf.Clamp(state.CurrentLevel + level, 1, state.MaxLevel);
            return state.CurrentLevel;
        }

        protected virtual void MeleeAttack(float range, int meleeDamage) {}

        public virtual void TakeDamage(int damage)
        {
            if (ModifyHealth(-damage) <= 0)
            {
                OnDeath();
            }
        }

        private void CoolDown(float duration, Action onComplete)
        {
            StartCoroutine(CoolDownRoutine(duration, onComplete));
        }

        private static IEnumerator CoolDownRoutine(float duration, Action onComplete)
        {
            yield return new WaitForSeconds(duration);
            onComplete?.Invoke();
        }

        protected virtual void OnDeath()
        {
            // 處理實體死亡的基礎邏輯
        }

        protected virtual void GainExperience(int experience)
        {
            if (ModifyExperience(experience) >= state.MaxExperience)
            {
                LevelUp();
            }
        }

        protected virtual void LevelUp()
        {
            if (ModifyLevel(1) == state.MaxLevel)
            {
                OnMaxLevel();
            }
        }

        protected virtual void OnMaxLevel()
        {
            // 處理實體達到最高等級的基礎邏輯
        }

        protected virtual IActor GetPlayer() { return null; }
        protected virtual IActor GetNearestEnemy() { return null; }
        protected virtual List<IActor> GetNearbyEnemies() { return null; }
    }
}