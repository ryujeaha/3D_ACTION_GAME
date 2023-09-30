using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float hAxis;//���� Ű�Է��� ���� ����
    float vAxis;//���� Ű�Է��� ���� ����
    Vector3 MoveVec;//������ ���� ����.

    bool walk_Down;

    Animator myanim;

private void Awake() {
    myanim = GetComponentInChildren<Animator>();//�ڽİ�ü �ִϸ����� ����.    
}

    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        hAxis = Input.GetAxisRaw("Horizontal");//���� Ű �Է� �ޱ�.
        vAxis = Input.GetAxisRaw("Vertical");//���� Ű �Է� �ޱ�.
        walk_Down = Input.GetButton("Walk");//����ƮŰ �Է¹ޱ�.

        MoveVec = new Vector3(hAxis,0,vAxis).normalized;//�밢���� �Է��ϸ� ��Ÿ��󽺿� ���ؼ� ��Ʈ2�� �����Ƿ� ������⿡���� ���� �븻������(�Ϲ�ȭ)��Ŵ.
       
        transform.position += MoveVec * Speed *(walk_Down ? 0.3f:1f)* Time.deltaTime;
    
        myanim.SetBool("isRun",MoveVec != Vector3.zero);//�޸��� ����,�ƿ� Ű �Է��� ���� ���ΰ� �����ʴ��� �޸��� �ִ�.
        myanim.SetBool("isWalk",walk_Down);


        transform.LookAt(transform.position + MoveVec);//�迧�� ������ ���ͷ� ȸ�������ִ� �Լ��̴�.������ġ�� �������� �ϴ� ��ŭ�� �������� �ٶ󺻴�.
    }
}
