using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Enemy : MonoBehaviour, IPointerClickHandler
{
    private int health = 100;
    public Vector3 colliderSize;
    private bool isPlayerSelected;

    public abstract void Move();

    public virtual void Attack()
    {
        Debug.Log("Атаковать всех вокруг себя");
    }

    public virtual void GetCommand()
    {
        if (isPlayerSelected == true && health > 0)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                TakeDamage();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
            }
            
            Move();
        }
    }

    [ContextMenu("TakeDamage")]
    public virtual void TakeDamage()
    {
        if (health > 0)
        {
            health -= 10;
            Debug.Log($"Получено 10 единиц урона. Уровень здоровья = {health}");
        }

        if (health == 0)
        {
            health = 0;
            Debug.Log("Игрок умер!");
            Destroy(gameObject);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            isPlayerSelected = true;
            Debug.Log("Игрок выбран");
        }
        if (eventData.pointerId == -2)
        {
            isPlayerSelected = false;
            Debug.Log("Игрок деактивирован");
        }
    }
}
