using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public GameManager gameManager;
    public int playerHP = 100;
    //float fillProp = 0.75f;
    // Start is called before the first frame update
    void Start()
    {

        Image gaugeCtrl = GetComponent<Image>();
        //gaugeCtrl.fillAmount = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHP <= 0)
        {
            gameManager.ChangeScene("GameoverScene");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            Debug.Log("s");
            playerHP = playerHP - 10;
            gameManager.AddPlayerhpCount();


        }
    }

    public void Damage()
    {
        //playerHP = playerHP - 10;
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("d");
            playerHP = playerHP - 300;
            gameManager.AddPlayerhpCount();
        }
        
    }

}
