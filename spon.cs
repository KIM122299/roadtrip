using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spon : MonoBehaviour
{
    public GameObject unit; //���� ������Ʈ ����
    public Transform spownPos; //������ ������Ʈ ��ġ ����
    public static int i = 0; //�ڸ� ������ ���� ����
    public int Cust = 0; //�մԼ�

    
    // Start is called before the first frame update
    void Spawn() //�մԻ���
    {
        if (Cust < 3) //�մ��� 3�� �̸��̸� ����
        {
            Instantiate(unit); //unit ����          
        }
        i++; // ���� �ڸ���
        Cust++;//�մԼ�++
        if (i == 4) //�ڸ��� 3���̹Ƿ� 4���Ǹ� �ʱ�ȭ
        {
            i = 1;
        }
    }
    void Start()
    {
        InvokeRepeating("Spawn", 3, 5);//���� 3���� Spawn 3���� �������� ����
        //Debug.Log("12 = " +Cust);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
