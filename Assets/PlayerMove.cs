using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private int playerHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            GetComponent<BoxCollider>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<BoxCollider>().enabled = true;
        }

        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 0.3f;
            if (Input.GetKey(KeyCode.D))
            {
                pos.x -= 0.05f;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 0.3f;
            if (Input.GetKey(KeyCode.D))
            {
                pos.x += 0.05f;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += 0.3f;
            if (Input.GetKey(KeyCode.D))
            {
                pos.y -= 0.05f;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= 0.3f;
            if (Input.GetKey(KeyCode.D))
            {
                pos.y += 0.05f;
            }
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);

    }
    public void Damage()
    {
    }
}
