using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    
    public GameManager gameManager;
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
        velocity.z = 0.6f;
        
        if (velocity.x != 0 || velocity.z != 0)
        {
            transform.position += transform.rotation * velocity;
        }
        if(660<Input.mousePosition.x && 1260 > Input.mousePosition.x)
        {
            if (200 < Input.mousePosition.y && 880 > Input.mousePosition.y)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //ワールドの上ベクトルとRAy方向のベクトルの内積
                float pro1 = Vector3.Dot(Vector3.up, ray.direction);
                //ワールドの下ベクトルとRAy方向のベクトルの内積
                float pro2 = Vector3.Dot(Vector3.down, ray.direction);
                //角度差を求める
                float rad1 = Mathf.Acos(pro1);
                float rad2 = Mathf.Acos(pro2);
                //角度
                float rad = 10 * Mathf.Deg2Rad;
                if (rad1 >= rad && rad2 >= rad)
                {
                    transform.rotation = Quaternion.LookRotation(ray.direction);
                }
            }
            
        }
        
        
    }
   
}
