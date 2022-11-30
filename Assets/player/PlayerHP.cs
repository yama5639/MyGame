using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    public GameManager gameManager;
    public int playerHP;
    // Start is called before the first frame update
    void Start()
    {
        playerHP = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHP <= 0)
        {
            //Destroy(this.gameObject);
            //gameManager.ChangeScene("GameoverScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            playerHP = playerHP - 1;
            if (playerHP <= 0)
            {
                gameManager.ChangeScene("GameoverScene");
            }
            
        }
    }

}
