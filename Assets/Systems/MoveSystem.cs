using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
using Unity.Mathematics;

public class MoveSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
		Entities.ForEach((ref Translation pos, ref Rotation rot, ref MoveComponent speed) => {
			// transform.localPosition = transform.localPosition + speed * transform.TransformVector(Vector3.up);
			pos.Value = pos.Value + speed.speed * math.mul(rot.Value, math.up());
		});
	}
}