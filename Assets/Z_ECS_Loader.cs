using System.Collections;
using System.Collections.Generic;
using Unity.Rendering;
using Unity.Transforms;
using Unity.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class Z_ECS_Loader
{
    public static Z_GameSetting gameSetting;

    public static MeshRenderer aaa;
    // public static MeshInst
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void InitAfterSceneLoaded()
    {
        Debug.Log("InitAfterSceneLoaded");

        gameSetting = GameObject.Find("ZECSGameSetting")?.GetComponent<Z_GameSetting>();
        
        Debug.Log("BallNumber: " + gameSetting?.BallNumber);
    }
    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void BeforeSceneLoad()
    {
        Debug.Log("BeforeSceneLoad");
    }
}
