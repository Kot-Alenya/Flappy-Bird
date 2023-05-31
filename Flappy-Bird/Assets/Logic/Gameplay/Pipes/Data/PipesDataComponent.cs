using Entitas.CodeGeneration.Attributes;
using Entitas;

namespace FlappyBird.Gameplay.Pipes
{
    [Input, Unique]
    public class PipesDataComponent : IComponent
    {
        public PipesFactory Factory;
        public float TimeToSpawn;
        public float SpawnRate;
        public float RemoveRate;
    }
}