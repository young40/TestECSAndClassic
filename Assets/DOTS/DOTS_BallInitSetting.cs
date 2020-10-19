using Unity.Entities;

namespace DOTS
{
    public struct DOTS_BallInitSetting : IComponentData
    {
        public int BallNumber;
        public int BallBound;
        
        public Entity Prefab;
    }
}