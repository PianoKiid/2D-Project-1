using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    int speed = 10; //���ǵ� 

    void Start()
    {
        
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime; //x������ �̵��� ��
        float yMove = Input.GetAxis("Vertical") * speed * Time.deltaTime; //y������ �̵��Ҿ�
        this.transform.Translate(new Vector3(xMove, yMove, 0));  //�̵�
    }
}
