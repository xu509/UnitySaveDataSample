using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public EnemyScript enemy;

    public EnemyData[] levelData;

    [Range(1,5)]
    public int level;

    private void Start()
    {
        // level <= array size
        if (level > levelData.Length) {
            level = levelData.Length;
        }

        // pass SO info into our enemy
        enemy.data = levelData[level - 1];
    }

}


