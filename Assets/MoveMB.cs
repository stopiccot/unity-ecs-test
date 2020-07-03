using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMB : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.localPosition = transform.localPosition + speed * transform.TransformVector(Vector3.up);
    }
}
