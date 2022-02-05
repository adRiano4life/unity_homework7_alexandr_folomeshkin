using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Warrior : Enemy
{
    [ContextMenu("Move")]
    public override void Move()
    {
        Vector3 playerPosition = transform.position;
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerPosition = Vector3.forward;
            transform.position += playerPosition;
            Attack();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            playerPosition = Vector3.back;
            transform.position += playerPosition;
            Attack();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            playerPosition = Vector3.left;
            transform.position += playerPosition;
            Attack();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            playerPosition = Vector3.right;
            transform.position += playerPosition;
            Attack();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerPosition = Vector3.up;
            transform.position += playerPosition;
            Attack();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerPosition = Vector3.down;
            transform.position += playerPosition;
            Attack();
        }
    }
    
    public override void Attack()
    {
        BoxCollider collider = gameObject.AddComponent<BoxCollider>();
        collider.size = colliderSize;
        Debug.Log($"Воин атакует всех, кого он встретит на пути!");
        DestroyImmediate(collider);
    }
    
    void Update()
    {
        GetCommand();
    }
}
