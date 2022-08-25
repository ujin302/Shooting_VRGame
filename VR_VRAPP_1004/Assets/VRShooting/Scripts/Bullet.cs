using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour // 총알 속도, 움직임
{
    float speed = 20.0f;
    float liftTime = 3.0f;
    private Rigidbody rb;
    public GameObject hitParticlPrefeb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(this.gameObject, liftTime);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.SendMessage("OnHitBullet");
        Destroy(gameObject);

        GameObject temp = Instantiate(hitParticlPrefeb, transform.position, transform.rotation);
        Destroy(temp, 1f);
    }
}
