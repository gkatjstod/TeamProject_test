﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Move : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button0)) { transform.Translate(Vector3.left * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.RightArrow)) { transform.Translate(Vector3.right * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.UpArrow)) { transform.Translate(Vector3.forward * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.DownArrow)) { transform.Translate(Vector3.back * speed * Time.deltaTime); }
    }
}
