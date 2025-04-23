
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // ���볡�����������ռ�

public class SceneJump : MonoBehaviour
{
    public string sceneName; // Ŀ�곡�������� 

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneName); // SceneManager ��Ҫ UnityEngine.SceneManagement �����ռ�
        }
    }
}
