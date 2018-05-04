using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Director : Singleton<Director> {
    [SerializeField]
    private GameObject mainPlanePrefab;

    
    [SerializeField]
    private int score;
    public int Score {
        get { return score; }
        set{
            score = value;


        }
    }
    private EnemyFactoryBase enemyFactoryBase;


    protected override void Awake () {
        base.Awake();
        Instantiate(mainPlanePrefab, mainPlanePrefab.transform.position, Quaternion.identity);
        enemyFactoryBase = new EnemyFactoryBase();
        enemyFactoryBase.CreateEnemy(EnemyType.NormalEnemy);
        enemyFactoryBase.CreateEnemy(EnemyType.Boss);

    }

    void OnGUI()
    {
        if (Input.anyKeyDown)
        {
            Event e = Event.current;
            if (e != null && e.isKey && e.keyCode != KeyCode.None)
            {
                print(e.keyCode);
            }
        }
    }
}
