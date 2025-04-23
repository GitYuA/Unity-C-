//WADS移动，空格跳跃，鼠标控制视角
//脚本绑定到需要对应操作的对象上
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wads : MonoBehaviour
{
    public float speed = 5.0f; // 移动速度

    void Update()
    {
        // 获取水平和垂直输入值（A/D和W/S）
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // 根据输入值移动物体
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        transform.Translate(movement * speed * Time.deltaTime);

        //跳跃
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //跳跃
            transform.position += new Vector3(0, 1, 0);
        }

        //鼠标移动，控制视角
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 rotation = new Vector3(mouseY, mouseX, 0);
        transform.Rotate(rotation);
    }
}
