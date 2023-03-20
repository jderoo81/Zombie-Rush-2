using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void Shot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rigid = bullet.GetComponent<Rigidbody2D>();
        
        rigid.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
