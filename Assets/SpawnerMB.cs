using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMB : MonoBehaviour
{
    [SerializeField]
    private float timeout;

    [SerializeField]
    private GameObject prefab;

    private float t = 0.0f;

    void Update()
    {
        t -= Time.deltaTime;
        if (t < 0) {
            Instantiate(prefab, new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0.0f), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f))); ;
            t = timeout;
        }
    }
}
