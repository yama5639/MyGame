using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 1;
    public float time = 2;
    protected Vector3 forward =
    new Vector3(1,1,1);
    protected Quaternion forwardAxis =
    Quaternion.identity;
    protected Rigidbody rb;
    protected GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        if(enemy != null)
        {
            forward = enemy.transform.forward;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = forwardAxis * forward * speed;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z);
        time -= Time.deltaTime;
        //if(time <= 0)
        //{
        //    Destroy(this.gameObject);
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "PlayerBody")
        {
            Destroy(this.gameObject);
        }
    }

    public void SetCharacterObject(GameObject character)
    {
        this.enemy = character;
    }

    public void SetForWordAxis(Quaternion axis)
    {
        this.forwardAxis = axis;
    }
}
