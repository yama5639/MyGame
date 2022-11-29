using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardShot : MonoBehaviour
{
    private GameObject player;
    public GameObject bullet;
    public float speed = 5;
    public float time = 1;
    public float delayTime = 1;
    float nowtime = 0;

    // Start is called before the first frame update
    void Start()
    {
        nowtime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        nowtime -= Time.deltaTime;
        if (nowtime <= 0)
        {
            CreateShotObject(-transform.localEulerAngles.y);
            nowtime = time;
        }
    }

    private void CreateShotObject(float axis)
    {
        var direction = player.transform.position - transform.position;
        
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletObject = bulletClone.GetComponent<EnemyBullet>();
        bulletObject.SetCharacterObject(gameObject);
        bulletObject.SetForWordAxis(lookRotation * Quaternion.AngleAxis(axis, Vector3.up));
    }
}
