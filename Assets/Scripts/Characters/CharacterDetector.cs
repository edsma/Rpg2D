using Assets.Scripts.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDetector : MonoBehaviour
{
    public static Action<EnemyInteraction> eventEnemyDectection;
    public static Action eventEnemyLost;
    public EnemyInteraction enemyInteraction { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Constants.Tags.enemy))
        {
            enemyInteraction = collision.GetComponent<EnemyInteraction>();
            eventEnemyDectection?.Invoke(enemyInteraction);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(Constants.Tags.enemy))
        {
            eventEnemyLost?.Invoke();
        }
    }
}
