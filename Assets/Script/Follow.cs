using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
public Transform target;//���󰡾��� Ÿ��
public Vector3 offset;//���ͺ並 �����ϱ����� �����ؾ��� ���� ��ġ��
    void Update()
    {
        transform.position = target.position + offset;//���� ��ġ������ �÷��̾� �߰�
    }
}
