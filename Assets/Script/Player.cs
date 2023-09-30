using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float hAxis;//가로 키입력을 받을 변수
    float vAxis;//세로 키입력을 받을 변수
    Vector3 MoveVec;//움직일 벡터 변수.

    bool walk_Down;

    Animator myanim;

private void Awake() {
    myanim = GetComponentInChildren<Animator>();//자식객체 애니메이터 접근.    
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
        hAxis = Input.GetAxisRaw("Horizontal");//가로 키 입력 받기.
        vAxis = Input.GetAxisRaw("Vertical");//세로 키 입력 받기.
        walk_Down = Input.GetButton("Walk");//쉬프트키 입력받기.

        MoveVec = new Vector3(hAxis,0,vAxis).normalized;//대각선을 입력하면 피타고라스에 의해서 루트2가 나오므로 어느방향에서든 같게 노말라이즈(일반화)시킴.
       
        transform.position += MoveVec * Speed *(walk_Down ? 0.3f:1f)* Time.deltaTime;
    
        myanim.SetBool("isRun",MoveVec != Vector3.zero);//달리기 구현,아예 키 입력이 없어 제로가 되지않는한 달릴수 있다.
        myanim.SetBool("isWalk",walk_Down);


        transform.LookAt(transform.position + MoveVec);//룩엣은 지정된 벡터로 회전시켜주는 함수이다.지금위치에 움직여야 하는 만큼의 방향으로 바라본다.
    }
}
