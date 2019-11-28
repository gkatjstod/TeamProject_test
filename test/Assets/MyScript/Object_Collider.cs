using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Object_Collider : MonoBehaviour
{
    public int LV;//레벨
    public int MaxLV;//최대레벨
    public int Exp;//경험치
    public int MaxExp;//최대경험치
    public int SCORE;//점수
    public float Hunger;//배고픔게이지

  
 

    public float _timeInterver;//지나간시간 일단시간만재는중
    public float _EatInterver; //먹기딜레이 현재적용x


    bool End;//종료확인

    public Text Text_hunger;//배고픔 실린더
    public Text Text_score;//점수 텍스트 & _timeInterver>= _EatInterver
    public Text Text_lv;//레벨 텍스트
    public Text Text_exp;//경험치 텍스트
    public Text Text_End;//종료 텍스트

    public Slider slider_hunger;//배고픔 실린더

   
    // Start is called before the first frame update
    void Start()
    {
        LV = 1;
        MaxExp = 3;
        SCORE = 0;
        Hunger = 100;
       


    }

    // Update is called once per frame
    void Update()
    {
        //End가 false이면 배고픔감소 
        if (End == false)
        {
            _timeInterver += Time.deltaTime;
            //레벨1일때 배고픔이 0이하가되면 End = true
            if (Hunger <= 0 & LV ==1)
            { End = true; }
            //그외에 배고픔이 0이하가되면 레벨다운 
            if (Hunger <= 0)
            {
                if (LV > 1)
                {
                    LV--;
                    Hunger = 20;
                }
            }

            Hunger -= 5.0f * Time.deltaTime;
           
        }
        //게이지가 변경되면

        //텍스트출력
        Text_hunger.text = "hunger: " + Hunger.ToString();
        Text_score.text = "Score: " + SCORE.ToString();
        Text_lv.text = "LV: " + LV.ToString();
        Text_exp.text = "Exp: " + Exp.ToString();
        Text_End.text = "End: " + End.ToString();
        slider_hunger.value = Hunger;
    }

    private void OnCollisionStay(Collision other)//충돌중일때
    {
        
            switch (other.gameObject.tag)
            {
                case "LV1":  { EatObject(other,1, 1, 10, 10); } break;
                case "LV2":  { EatObject(other,2, 1, 15, 20); } break;                  
                case "LV3":  { EatObject(other,3, 1, 20, 30); } break;                  
                default: break;
            }
     
    }
    

    void EatObject(Collision other, int level, int exp, int score, int hunger)
    {
        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            //레벨이 오브젝트레벨보다 크거나같을때 먹음
            if (LV >= level)
            {

                Destroy(other.gameObject);//오브젝트제거
                                          //수치증가
                Exp += exp;
                SCORE += score;
                Hunger += hunger;
                //레벨업
                if (Exp >= MaxExp && LV < MaxLV)
                {
                    Exp = Exp - MaxExp;
                    MaxExp += 2;
                    LV++;
                }


            }

        }
    }
}

