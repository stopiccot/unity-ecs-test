using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class MoveMB : MonoBehaviour, IConvertGameObjectToEntity
{
    public float speed;

    void Update()
    {
        transform.localPosition = transform.localPosition + speed * transform.TransformVector(Vector3.up);
    }

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new MoveComponent { speed = this.speed });
    }
}
