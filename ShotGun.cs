using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{
    [SerializeField] private float _angle;

    public override void Shoot(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.AngleAxis(_angle, new Vector3(0,0,1)));
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        Instantiate(Bullet, shootPoint.position, Quaternion.AngleAxis(-_angle, new Vector3(0, 0, 1)));
    }
}
