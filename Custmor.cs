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

    private bool moving; // �̵������� Ȯ��
    private Vector3 destination; // �̵��� ������ 

    
    void Start()
    {
        
        time = 5.0f;
        sitPosNum = spon.i;

        Debug.Log(sitPosNum);
        Debug.Log(moving);
    }

    void Update()
    {
        
        if (moving) // �¼��� �������� ���
        {
            MoveToDestination();
        }
        else 
        {
            Move();
            time -= Time.deltaTime;
            

            if (time <= 0) // �ð��� 0�̵Ǹ� ����
            {
                StartMovingToDestination(getOut.position); //StartMovingToDestination�Լ��� getOut�� ��ġ�� ����

                CustNum = GameObject.Find("SponCtrl"); //SpoCtrl�O��
                CustNum.GetComponent<spon>().Cust--; //SponCtrl�� ��ũ��Ʈ spon�� Cust�� ����
            }
        }
    }

    void Move() //�¼����� �̵�
    {
        if (sitPosNum == 1) //1���¼�
        {
            StartMovingToDestination(sitPosition1.transform.position); //1���¼� ��ġ�� ����
        }
        else if (sitPosNum == 2) //2���¼�
        {
            StartMovingToDestination(sitPosition2.transform.position); //2���¼� ��ġ�� ����
        }
        else if (sitPosNum == 3) //3���¼�
        {
            StartMovingToDestination(sitPosition3.transform.position); //3���¼� ��ġ�� ����
        }
    }

    void StartMovingToDestination(Vector3 targetPosition) //���� ��ġ�� �̵�
    {
        destination = targetPosition; //���� ��ġ���� destination�� ����
        moving = true; //�̵�����
    }

    void MoveToDestination()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, 0.05f); //destination���� �̵�

        if (transform.position == destination) // �������� ������ ���
        {
            moving = false; //�̵���
        }
    }
}
