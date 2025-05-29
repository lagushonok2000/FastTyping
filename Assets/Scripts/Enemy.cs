using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _damage;
    private Tower _tower;

    private void Update()
    {
        Attack();
    }

    private void Attack()
    {
        GameObject tower = GameObject.Find("tower");

        if (Vector3.Equals(gameObject.transform.position, tower.transform))
        {
            _tower.TowerHealth -= _damage;
            _tower.GetAttacked();
            Destroy(gameObject);
        }
    }
}
