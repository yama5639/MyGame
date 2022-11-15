using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private static bool visible;
    private static CursorLockMode lockState;
    private Vector3 mouse;
    private Vector3 target;

    private void Start()
    {
        //カーソル非表示
        //Cursor.visible = false; 
    }
    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        target = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, 10));
        this.transform.position = target;
    }
}
