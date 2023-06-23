using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spon : MonoBehaviour
{
    public GameObject unit; //생성 오브젝트 연결
    public Transform spownPos; //생성된 오브젝트 위치 연결
    public static int i = 0; //자리 선정을 위한 변수
    public int Cust = 0; //손님수

    
    // Start is called before the first frame update
    void Spawn() //손님생성
    {
        if (Cust < 3) //손님이 3명 미만이면 생성
        {
            Instantiate(unit); //unit 생성          
        }
        i++; // 다음 자리로
        Cust++;//손님수++
        if (i == 4) //자리가 3개이므로 4개되면 초기화
        {
            i = 1;
        }
    }
    void Start()
    {
        InvokeRepeating("Spawn", 3, 5);//시작 3초후 Spawn 3초의 간격으로 생성
        //Debug.Log("12 = " +Cust);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
