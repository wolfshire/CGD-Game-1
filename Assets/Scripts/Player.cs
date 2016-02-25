using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    [SerializeField]
    int speed = 5;
    [SerializeField]
    int bounds = 2;
    [SerializeField]
    GameObject bullet;
    Vector3 pos;

    float shotTimer = 0;
    bool canShoot = true;

    [SerializeField]
    float cooldown = .5f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //mouse click
        if (Input.GetMouseButton(0) && canShoot)
        {
            canShoot = false;
            pos = Input.mousePosition;
            pos.z = 10.0f;       // we want 2m away from the camera position
            pos = Camera.main.ScreenToWorldPoint(pos);
            Instantiate(bullet, pos, Quaternion.identity);
        }
        //cooldown on shots
        if (!canShoot)
        {
            shotTimer += Time.deltaTime;
            if (shotTimer > cooldown)
            {
                canShoot = true;
                shotTimer = 0;
            }
        }

    }
}