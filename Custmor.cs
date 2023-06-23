using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Custmor : MonoBehaviour
{
    public GameObject sitPosition1;
    public GameObject sitPosition2;
    public GameObject sitPosition3;
    public Transform getOut;

    private int sitPosNum;
    public GameObject CustNum;
    private float time;

    private bool moving; // 이동중인지 확인
    private Vector3 destination; // 이동할 목적지 

    
    void Start()
    {
        
        time = 5.0f;
        sitPosNum = spon.i;

        Debug.Log(sitPosNum);
        Debug.Log(moving);
    }

    void Update()
    {
        
        if (moving) // 좌석에 도착했을 경우
        {
            MoveToDestination();
        }
        else 
        {
            Move();
            time -= Time.deltaTime;
            

            if (time <= 0) // 시간이 0이되면 실행
            {
                StartMovingToDestination(getOut.position); //StartMovingToDestination함수에 getOut의 위치값 전달

                CustNum = GameObject.Find("SponCtrl"); //SpoCtrl찿기
                CustNum.GetComponent<spon>().Cust--; //SponCtrl의 스크립트 spon의 Cust수 감소
            }
        }
    }

    void Move() //좌석으로 이동
    {
        if (sitPosNum == 1) //1번좌석
        {
            StartMovingToDestination(sitPosition1.transform.position); //1번좌석 위치값 전달
        }
        else if (sitPosNum == 2) //2번좌석
        {
            StartMovingToDestination(sitPosition2.transform.position); //2번좌석 위치값 전달
        }
        else if (sitPosNum == 3) //3번좌석
        {
            StartMovingToDestination(sitPosition3.transform.position); //3번좌석 위치값 전달
        }
    }

    void StartMovingToDestination(Vector3 targetPosition) //받은 위치로 이동
    {
        destination = targetPosition; //받은 위치값을 destination에 저장
        moving = true; //이동시작
    }

    void MoveToDestination()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, 0.05f); //destination으로 이동

        if (transform.position == destination) // 목적지에 도착한 경우
        {
            moving = false; //이동끝
        }
    }
}
