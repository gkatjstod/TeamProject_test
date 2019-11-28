using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_MoveDerection : MonoBehaviour
{
    public float MoveSpeed;
    Vector3 lookDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //상하좌우화살표키 입력을 받으면
        if (Input.GetKey(KeyCode.LeftArrow) ||
           Input.GetKey(KeyCode.RightArrow) ||
           Input.GetKey(KeyCode.UpArrow) ||
           Input.GetKey(KeyCode.DownArrow))
        {
            //해당방향으로설정
            float xx = Input.GetAxisRaw("Vertical");
            float zz = Input.GetAxisRaw("Horizontal");
            lookDirection = xx * Vector3.forward + zz * Vector3.right;

            //방향으로 전진
            this.transform.rotation = Quaternion.LookRotation(lookDirection);
            this.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }

        
    }
}
