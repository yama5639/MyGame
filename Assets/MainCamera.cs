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
        GetComponent<Transform>().rotation = sphere.rotation;
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //transform.rotation = Quaternion.LookRotation(ray.direction);
        //float sensitiveMove = 0.2f;
        //float moveX = Input.GetAxis("Mouse X") * sensitiveMove;
        //float moveY = Input.GetAxis("Mouse Y") * sensitiveMove;
        //cam.transform.localPosition -= new Vector3(moveX, moveY, 0.0f);
        //float Rotation = 0.1f;
        //cam = GetComponent<Camera>();
        //float rotateX = Input.GetAxis("Mouse X") * Rotation;
        //float rotateY = Input.GetAxis("Mouse Y") * Rotation;
        //cam.transform.Rotate(rotateX, rotateY, 0.0f);

    }
}
