using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var vel = Vector3.zero;
        vel.y += 0.2f;
        vel.z += 3.0f;
        if (vel.x != 0 || vel.z != 0)
        {
            transform.position += transform.rotation * vel;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy>().Damage();
            Destroy(gameObject);
        }
    }
}
