using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int enemyHp;
    public GameManager gameManager;
    private ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject gameObject = GameObject.Find("GameManager");
        //gameManager = managerObject.GetComponent<GameManager>();
        enemyHp = 1;
        particle = GetComponentInChildren<ParticleSystem>();
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "PlayerBody")
        {

            enemyHp = enemyHp - 1;
        }
    }

    public void Damage()
    {
        enemyHp = enemyHp - 1;
        //particle.Play();
    }
    
}
