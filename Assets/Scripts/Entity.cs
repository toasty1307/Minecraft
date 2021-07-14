using UnityEngine;

namespace Minecraft
{
    public abstract class Entity : ScriptableObject
    {
        public float Health;
        public abstract void Die();
        public abstract void Spawn();
    }
}
