using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    private int playerHP;
    // Start is called before the first frame update
    void Start()
    {
        playerHP = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            playerHP = playerHP - 1;
        }
    }
}
