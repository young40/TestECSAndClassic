using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

namespace DOTS
{
    [RequiresEntityConversion]
    [ConverterVersion("Ball", 1)]
    public class DOTS_BallInit_Authoring : MonoBehaviour, IDeclareReferencedPrefabs, IConvertGameObjectToEntity
    {
        public int BallNumber = 100;
        public int BallBound = 50;
        
        public GameObject Prefab;
        
        public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
        {
            referencedPrefabs.Add(Prefab);
        }

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
            var data = new DOTS_BallInitSetting
            {
                BallNumber = BallNumber,
                BallBound = BallBound,
                
                Prefab = conversionSystem.GetPrimaryEntity(Prefab)
            };

            dstManager.AddComponentData(entity, data);
        }
    }
}