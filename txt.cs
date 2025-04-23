using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txt : MonoBehaviour
{
    public Animator dollAnimator; // ��ż�Ķ���������
    public GameObject welcomeText; // ��ӭ���ֶ���

    private void Start()
    {
        if (welcomeText != null)
        {
            welcomeText.SetActive(false); // ��ʼ���ػ�ӭ����
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ����Ƿ�����Ҵ���
        {
            if (dollAnimator != null)
            {
                dollAnimator.SetTrigger("Welcome"); // ������ż�Ļ�ӭ����
            }

            if (welcomeText != null)
            {
                welcomeText.SetActive(true); // ��ʾ��ӭ����
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // ����Ƿ�������뿪������
        {
            if (welcomeText != null)
            {
                welcomeText.SetActive(false); // ���ػ�ӭ����
            }
            if (dollAnimator != null)
            {
                dollAnimator.SetTrigger("Exit"); // ������ż���˳�����
            }
        }
    }
}
