using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderMB : MonoBehaviour
{
    private SpriteRenderer sprite;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");
        if (sprite != null)
        {
            sprite.color = Color.blue;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D");
        if (sprite != null)
        {
            sprite.color = Color.green;
        }
    }
}
