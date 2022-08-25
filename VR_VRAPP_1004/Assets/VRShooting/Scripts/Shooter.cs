using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour // ÃÑ¾Ë À§Ä¡ ÁöÁ¤ ¹× ÃÑ½î±â
{
    public GameObject bulletPrefabs;
    public Transform gunBarrelEnd;
    public ParticleSystem gunParticle;
    
    public AudioSource gunAudidSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefabs, gunBarrelEnd.position, gunBarrelEnd.rotation);
        gunParticle.Play();
        gunAudidSource.Play();
    }
}
