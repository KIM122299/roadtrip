using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class img : MonoBehaviour
{
    
    public Sprite[] images; // �����ϰ� ������ �̹������� �迭
    

    private SpriteRenderer SR; //��������Ʈ ������ 

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        // �̹��� ����
        int randomIndex = Random.Range(1, images.Length); //�̹����� �Ѱ� �������� ����
        SR.sprite = images[randomIndex]; //�̹��� ���
    }

    private void Update()
    {
        
    }
}
