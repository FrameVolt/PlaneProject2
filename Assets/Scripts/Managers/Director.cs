using System;
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

    private int liftCount = 3;
    public int PlayerLifeCount {
        get { return liftCount; }
    }

    public event Action OnPlayerDead;
    public event Action OnPlayerRespawn;
    public event Action OnGameOver;


    protected override void Awake () {
        base.Awake();
        Instantiate(mainPlanePrefab, mainPlanePrefab.transform.position, Quaternion.identity);
        enemyFactoryBase = new EnemyFactoryBase();
        enemyFactoryBase.CreateEnemy(EnemyType.NormalEnemy);
        enemyFactoryBase.CreateEnemy(EnemyType.Boss);

    }


    public void PlayerDead() {

        if (OnPlayerDead != null) {
            OnPlayerDead.Invoke();
        }
        liftCount--;
        if (liftCount > 0)
        {
            
            StartCoroutine(WaitPlayerDead());
        }
        else
        {
            print("GameOver");
            if (OnGameOver != null) {
                
                OnGameOver.Invoke();
            }
            
        }
    }

    private IEnumerator WaitPlayerDead() {

        yield return new WaitForSeconds(2f);
        Instantiate(mainPlanePrefab, mainPlanePrefab.transform.position, Quaternion.identity);
        if (OnPlayerRespawn != null)
            OnPlayerRespawn.Invoke();
    }

    //void OnGUI()
    //{
    //    if (Input.anyKeyDown)
    //    {
    //        Event e = Event.current;
    //        if (e != null && e.isKey && e.keyCode != KeyCode.None)
    //        {
    //            print(e.keyCode);
    //        }
    //    }
    //}
}
