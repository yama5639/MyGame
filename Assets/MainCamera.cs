using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform sphere;
    private Camera cam;

    void LateUpdate()
    {
        var adjustment = new Vector3(0.0f, 2.0f, -5.0f);
        GetComponent<Transform>().position = sphere.position + adjustment;

        float sensitiveMove = 0.2f;
        cam = GetComponent<Camera>();
        float moveX = Input.GetAxis("Mouse X") * sensitiveMove;
        float moveY = Input.GetAxis("Mouse Y") * sensitiveMove;
        cam.transform.localPosition -= new Vector3(moveX, moveY, 0.0f);
    }
}
