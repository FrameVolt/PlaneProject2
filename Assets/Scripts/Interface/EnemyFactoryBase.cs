using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType { NormalEnemy, Boss}

public class EnemyFactoryBase{
    public GameObject NormalEnemy { get; private set; }
    public GameObject BossEnemy { get; private set; }

    public EnemyFactoryBase() {
        NormalEnemy = Resources.Load<GameObject>("Prefabs/NormalEnemy");
        BossEnemy = Resources.Load<GameObject>("Prefabs/TankEnemy");
    }
    
    public GameObject CreateEnemy(EnemyType enemyType)
    {
        GameObject obj = null;
        if (enemyType == EnemyType.NormalEnemy)
        {
            obj = GameObject.Instantiate(NormalEnemy, NormalEnemy.transform.position, NormalEnemy.transform.rotation);
        }
        else if (enemyType == EnemyType.Boss)
        {
            obj = GameObject.Instantiate(BossEnemy, BossEnemy.transform.position, BossEnemy.transform.rotation);
        }

        return obj;
    }

    
}
