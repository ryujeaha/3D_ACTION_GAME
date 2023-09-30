using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
public Transform target;//따라가야할 타겟
public Vector3 offset;//쿼터뷰를 연출하기위해 유지해야할 기존 위치값
    void Update()
    {
        transform.position = target.position + offset;//기존 위치값에서 플레이어 추격
    }
}
