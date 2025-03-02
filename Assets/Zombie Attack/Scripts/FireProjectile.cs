using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FireProjectile : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletActiveTime = 3;
    public float bulletPower = 10;

    public GameObject firepoint;

    public float maxAmmo = 20;
    public TextMeshProUGUI ammoText;
    public float reloadTime = 3f;

    private float ammoCount;

    void Start()
    {
        ammoCount = maxAmmo;
        ammoText.text = $"Ammo: {ammoCount}";
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1") && ammoCount > 0)
        {
            // LESSON 3-3: Add code below.
            GameObject bullet = Instantiate(bulletPrefab);
            Destroy(bullet, bulletActiveTime);
            BulletScript bulletScript = bullet.GetComponent<BulletScript>();
            
            ammoText.text = $"Ammo: {ammoCount}";
        }

        // LESSON 3-4: Add code below.
    }

    private void FireBullet(BulletScript bullet)
    {
        bullet.transform.position = firepoint.transform.position;
        bullet.FireBullet(this.transform.forward, bulletPower);
    }

    public IEnumerator Reloading()
    {
        // LESSON 3-4: Add code below.

        yield return new WaitForSeconds(0);
        
        // LESSON 3-4: Add code below.
    }
}
