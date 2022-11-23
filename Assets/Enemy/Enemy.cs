using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int enemyHp;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject gameObject = GameObject.Find("GameManager");
        //gameManager = managerObject.GetComponent<GameManager>();
        enemyHp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHp <= 0)
        {
            gameManager.AddEnemyCount();
            Destroy(this.gameObject);
        }
    }

    public void Damage()
    {
        enemyHp = enemyHp - 1;
        
    }
    
}
