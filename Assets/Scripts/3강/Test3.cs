using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    public Transform player;
    public float viewAngle = 30f;

    public Transform target;

    void Start()
    {
        
    }

    void Update()
    {
        Test5();
        Test6();
    }

    private void Test5() //������ ����� �޼���
    {
        Vector3 toPlayer = (player.position - transform.position).normalized;
        Vector3 forward = transform.forward;

        float dot = Vector3.Dot(forward, toPlayer);
        float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;

        if (angle < viewAngle / 2)
        {
            Debug.Log("�÷��̾ �þ� �ȿ� ����!");
        }
    }

    private void Test6()
    {
        Vector3 playerForward = transform.forward;
        Vector3 toTarget = (target.position - transform.position).normalized;

        if (IsLeft(playerForward, toTarget, Vector3.up))
        {
            Debug.Log("Ÿ���� �÷��̾� ���� ���ʿ� ����");
        }
        else
        {
            Debug.Log("Ÿ���� �÷��̾� ���� �����ʿ� ����");
        }
    }

    bool IsLeft(Vector3 forward, Vector3 targetDirection, Vector3 up)
    {
        Vector3 cross = Vector3.Cross(forward, targetDirection);
        return Vector3.Dot(cross, up) > 0; //����� ����, ������ ������
    }
}
