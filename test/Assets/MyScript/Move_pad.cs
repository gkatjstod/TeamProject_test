using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_pad : MonoBehaviour
{
    public float MoveSpeed;
    Vector3 lookDirection;

    private MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //게임패드 왼쪽 스틱 조작시, 중립일시 0
        if (Input.GetAxisRaw("LeftStickHorizontal")!=0 
            || Input.GetAxisRaw("LeftStickVertical") != 0)
        {
            //해당방향으로설정
            float xx = Input.GetAxisRaw("LeftStickHorizontal");
            float zz = Input.GetAxisRaw("LeftStickVertical");
            lookDirection = -xx * Vector3.forward + zz * Vector3.right;

            //방향으로 전진
            this.transform.rotation = Quaternion.LookRotation(lookDirection);
            this.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }


    }


}
