using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {

    private EnemyFactoryBase enemyFactoryBase;
    void Awake () {
        enemyFactoryBase = new EnemyFactoryBase();
        enemyFactoryBase.CreateEnemy(EnemyType.NormalEnemy);
        enemyFactoryBase.CreateEnemy(EnemyType.Boss);

    }
    private void Start()
    {
        
    }

	
	void Update () {
		
	}
}
