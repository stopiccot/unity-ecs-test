using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;

public class SpawnerMB : MonoBehaviour
{
    [SerializeField]
    private bool useECS;

    [SerializeField]
    private float timeout;

    [SerializeField]
    private GameObject prefab;
    private Entity prefabEntity;

    private EntityManager manager;

    private float t = 0.0f;

    private void Awake()
    {
        if (useECS) {
            manager = World.DefaultGameObjectInjectionWorld.EntityManager;
            prefabEntity = GameObjectConversionUtility.ConvertGameObjectHierarchy(prefab, new GameObjectConversionSettings
            {
                DestinationWorld = World.DefaultGameObjectInjectionWorld
            });
        }
    }

    void Update()
    {
        t -= Time.deltaTime;
        if (t < 0) {
            var translation = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0.0f);
            var rotation = Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f));
            if (useECS) {
                var square = manager.Instantiate(prefabEntity);
                manager.SetComponentData(square, new Translation { Value = translation });
                manager.SetComponentData(square, new Rotation { Value = rotation });
            } else {
                Instantiate(prefab, translation, rotation);
            }
            t = timeout;
        }
    }
}
