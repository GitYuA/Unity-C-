using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txt : MonoBehaviour
{
    public Animator dollAnimator; // 人偶的动画控制器
    public GameObject welcomeText; // 欢迎文字对象

    private void Start()
    {
        if (welcomeText != null)
        {
            welcomeText.SetActive(false); // 初始隐藏欢迎文字
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // 检查是否是玩家触发
        {
            if (dollAnimator != null)
            {
                dollAnimator.SetTrigger("Welcome"); // 触发人偶的欢迎动画
            }

            if (welcomeText != null)
            {
                welcomeText.SetActive(true); // 显示欢迎文字
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // 检查是否是玩家离开触发器
        {
            if (welcomeText != null)
            {
                welcomeText.SetActive(false); // 隐藏欢迎文字
            }
            if (dollAnimator != null)
            {
                dollAnimator.SetTrigger("Exit"); // 触发人偶的退出动画
            }
        }
    }
}
