using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public int playerHP = 1;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (playerHP <= 0)
        //{
        //    gameManager.ChangeScene("GameoverScene");
        //}

        if (Input.GetKeyDown(KeyCode.U))
        {
            GetComponent<BoxCollider>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<BoxCollider>().enabled = true;
        }

        Vector3 pos = transform.position;
        var velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            //pos.x += 0.3f;
            velocity.x = 0.3f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //pos.x -= 0.3f;
            velocity.x = -0.3f;
        }
        velocity.z = 0.2f;
        //if (Input.GetKey(KeyCode.W))
        //{
        //    //pos.y += 0.3f;
        //    velocity.z = 0.3f;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    //pos.y -= 0.3f;
        //    velocity.z = -0.3f;
        //}
        if (velocity.x != 0 || velocity.z != 0)
        {
            transform.position += transform.rotation * velocity;
        }
        //transform.position = new Vector3(pos.x, pos.y, pos.z);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(ray.direction);

    }
    public void Damage()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Break();
        //playerHP = 0;
        gameManager.ChangeScene("GameoverScene");
    }

    
}
