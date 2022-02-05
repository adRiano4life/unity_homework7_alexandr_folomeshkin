using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Enemy
{
    [SerializeField] private Vector3 attackCoordinate;

    public override void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Лучник не может передвигаться");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Лучник не может передвигаться");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Лучник не может передвигаться");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Лучник не может передвигаться");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Лучник не может передвигаться");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Лучник не может передвигаться");
        }
        
    }

    [ContextMenu("Attack")]
    public override void Attack()
    {
        BoxCollider collider = gameObject.AddComponent<BoxCollider>();
        collider.size = colliderSize;
        collider.center = attackCoordinate;
        Debug.Log($"Лучние атакует врагов в радиусе {collider.bounds.extents.ToString()} " +
                  $"по координатам {collider.center.ToString()}");
        DestroyImmediate(collider);
    }

    void Update()
    {
        GetCommand();
    }
}
