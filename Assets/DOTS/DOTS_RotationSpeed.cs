using Unity.Entities;

namespace DOTS
{
    [GenerateAuthoringComponent]
    public struct DOTS_RotationSpeed : IComponentData
    {
        public float RadiansPreSecond;
    }
}