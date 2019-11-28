using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Input_PadButton : MonoBehaviour
{
    public static Input_PadButton instance;
    public Material mat;
   // Vector3 planePos;

    // Start is called before the first frame update


    void Awake()
    {
        instance = this;
    }


    void Start()
    {
        //mat.color = Color.blue;
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button0))//네모버튼 / 입력시 빨강
        {
            mat.color = Color.red;
        }
        if (Input.GetKey(KeyCode.Joystick1Button1))//엑스버튼 / 입력시 파랑
        {
            mat.color = Color.blue;
        }
        if (Input.GetKey(KeyCode.Joystick1Button2))//동그라미버튼 / 입력시 노랑
        {
            mat.color = Color.yellow;
        }
        if (Input.GetKey(KeyCode.Joystick1Button3))//세모버튼 / 입력시 초록
        {
            mat.color = Color.green;
        }
        if (Input.GetKey(KeyCode.Joystick1Button5))//r1 /입력시 마젠타
        {
            mat.color = Color.magenta;
        }
        if (Input.GetKey(KeyCode.Joystick1Button4))//l1 / 입력시 시안
        {
            mat.color = Color.cyan;
        }
    }
}
