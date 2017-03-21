using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {


    float nextFire = 0f;
    float fireRate = 0.2f;
    public Transform gunTip;
    public GameObject bullet;
    Animator myAnim;
    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Fire1") > 0)
        {
            fireBullet();
        }
    }

    void fireBullet()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        }
    }
}
