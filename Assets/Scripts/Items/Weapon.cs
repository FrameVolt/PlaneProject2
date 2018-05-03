using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    [SerializeField]
    private GameObject bulletPrefab = null;
    private float fireTimer;
    private float fireRate = 0.3f;

    public void FireOnce()
    {
        CreateBullet();
        fireTimer = 0;
    }

    public void FireStart() {
        fireTimer += Time.deltaTime;

        if (fireTimer > fireRate)
        {
            fireTimer = 0;
            CreateBullet();
        }
    }

    private void CreateBullet() {

        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }

}
