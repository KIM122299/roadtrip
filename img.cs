using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class img : MonoBehaviour
{
    
    public Sprite[] images; // 랜덤하게 선택할 이미지들의 배열
    

    private SpriteRenderer SR; //스프라이트 랜더러 

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        // 이미지 선택
        int randomIndex = Random.Range(1, images.Length); //이미지중 한개 랜덤으로 선택
        SR.sprite = images[randomIndex]; //이미지 출력
    }

    private void Update()
    {
        
    }
}
