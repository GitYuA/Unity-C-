//WADS�ƶ����ո���Ծ���������ӽ�
//�ű��󶨵���Ҫ��Ӧ�����Ķ�����
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wads : MonoBehaviour
{
    public float speed = 5.0f; // �ƶ��ٶ�

    void Update()
    {
        // ��ȡˮƽ�ʹ�ֱ����ֵ��A/D��W/S��
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // ��������ֵ�ƶ�����
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        transform.Translate(movement * speed * Time.deltaTime);

        //��Ծ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //��Ծ
            transform.position += new Vector3(0, 1, 0);
        }

        //����ƶ��������ӽ�
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 rotation = new Vector3(mouseY, mouseX, 0);
        transform.Rotate(rotation);
    }
}
