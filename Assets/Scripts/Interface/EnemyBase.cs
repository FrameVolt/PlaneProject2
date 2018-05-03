using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour, IHealth
{
    [SerializeField]
    protected GameObject bulletPrefab = null;
    [SerializeField]
    protected float speed = 1;
    [SerializeField]
    protected Vector3 direction = Vector3.down;
    [SerializeField]
    protected GameObject explosionFX;

    private int health = 100;

    public int Health
    {
        get { return health; }
    }

    private void Update() {
        Move();
    }

    protected virtual void Move() {
        transform.Translate(direction * Time.deltaTime * speed);
    }

    protected virtual void Attack() {
        GameObject bulletOBJ = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity);
        bulletOBJ.transform.rotation = Quaternion.Euler(0, 0, 180);
    }

    public void Damage(int _value)
    {
        if (health <= 0) return;
        health -= _value;

        if (health <= 0) {
            DestroySelf();
        }
    }

    private void DestroySelf() {
        Instantiate(explosionFX, this.transform.position, explosionFX.transform.rotation);
        Destroy(this.gameObject);
    }

}
