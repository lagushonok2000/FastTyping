using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDefence : MonoBehaviour
{
    [SerializeField] private StartGame _startGame;

    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _enemySpawn;

    public void EnemyAttack()
    {
        StartCoroutine(EnemyAttackCoroutine());
    }

    public IEnumerator EnemyAttackCoroutine()
    {
        for (int i = _startGame.GameTime; i >= 0; i--)
        {
            Instantiate(_enemy, _enemySpawn.position, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
}
