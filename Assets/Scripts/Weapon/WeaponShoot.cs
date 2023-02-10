using UnityEngine;

public class WeaponShoot : MonoBehaviour
{
    Transform bulletPoint;
    GameObject bullet;

    private void Start() {
        bulletPoint = transform.Find("BulletPosition");
        bullet = Resources.Load<GameObject>("Bullet");
        InvokeRepeating("DoShoot", 3f, 3f);
    }

    void DoShoot(){
        if(bulletPoint){
            var newBullet = GameObject.Instantiate(bullet, bulletPoint.position, bulletPoint.rotation);
        }
    }
}
