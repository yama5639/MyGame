using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform sphere;
    void LateUpdate()
    {
        var adjustment = new Vector3(0.0f, 2.0f, -5.0f);
        GetComponent<Transform>().position = sphere.position + adjustment;
    }
}
