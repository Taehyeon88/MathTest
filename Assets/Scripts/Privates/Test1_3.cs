using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1_3 : MonoBehaviour
{
    public int solution(int number, int limit, int power)
    {
        int answer = 0;
        int[] odds = new int[number + 1];
        for (int i = 1; i <= number; i++)
        {
            int temp = i;                     //������� �ӽ÷� �����ؼ� ���������� ��
            int num = 1;                      //����� ������ ���� ��
            int num2 = 1;
            int count = 0;
            while (temp > 1)
            {
                if (temp % 2 == 0)
                {
                    num++;
                    temp = temp / 2;
                }
                else
                {
                    if (odds[count] != 0)
                    {
                        if (temp % odds[count] == 0)
                        {
                            num2++;
                            temp = temp / odds[count];
                        }
                        else
                        {
                            num *= num2;
                            num2 = 1;
                            count++;
                        }
                    }
                    else
                    {
                        num *= 2;
                        odds[count] = temp;
                        //Debug.Log($"temp : {i}, ���ο� �Ҽ� : {temp}");
                        break;
                    }
                }
            }
            //Debug.Log($"temp : {i}, ����� ���� : {num}");
            if (num > limit) num = power;
            answer += num;
        }

        return answer;
    }
    void Start()
    {
        Debug.Log(solution(10, 3, 2));
    }
}
