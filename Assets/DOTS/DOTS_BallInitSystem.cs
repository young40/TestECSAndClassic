using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace DOTS
{
    public class DOTS_BallInitSystem : SystemBase
    {
        private BeginInitializationEntityCommandBufferSystem m_EntityCommandBufferSystem;
        
        protected override void OnCreate()
        {
            base.OnCreate();

            m_EntityCommandBufferSystem = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
        }

        protected override void OnUpdate()
        {
            var commandBuffer = m_EntityCommandBufferSystem.CreateCommandBuffer().AsParallelWriter();

            Entities.ForEach((Entity entity, int  entityInQueryIndex, in DOTS_BallInitSetting ballInitSetting, in LocalToWorld location) =>
            {
                for (var i = 0; i < ballInitSetting.BallNumber; i++)
                {
                    var instance = commandBuffer.Instantiate(entityInQueryIndex, ballInitSetting.Prefab);

                    var position = math.transform(location.Value, new float3(
                     0, //ballInitSetting.BallBound ,//* (UnityEngine.Random.value - 0.5f),
                     -10.0f,
                     0//ballInitSetting.BallBound// * (UnityEngine.Random.value - 0.5f)
                     ));
                
                    commandBuffer.SetComponent(entityInQueryIndex, instance, new Translation{Value = position});
                }

                commandBuffer.DestroyEntity(entityInQueryIndex, entity);
            }).ScheduleParallel();
            
            m_EntityCommandBufferSystem.AddJobHandleForProducer(Dependency);
        }
    }
}