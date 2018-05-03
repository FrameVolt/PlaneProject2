using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : EnemyBase
{
    [SerializeField]
    private float repeatRate = 0.3f;

    private void Start()
    {
        InvokeRepeating("Attack", 0f, repeatRate);
    }

}
