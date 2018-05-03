using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Director : MonoBehaviour {
    [SerializeField]
    private GameObject mainPlanePrefab;

    private EnemyFactoryBase enemyFactoryBase;
    
    void Awake () {

        Instantiate(mainPlanePrefab, mainPlanePrefab.transform.position, Quaternion.identity);

        enemyFactoryBase = new EnemyFactoryBase();
        enemyFactoryBase.CreateEnemy(EnemyType.NormalEnemy);
        enemyFactoryBase.CreateEnemy(EnemyType.Boss);

    }
    private void Start()
    {
        
    }

}
