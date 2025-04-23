
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // 引入场景管理命名空间

public class SceneJump : MonoBehaviour
{
    public string sceneName; // 目标场景的名称 

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(sceneName); // SceneManager 需要 UnityEngine.SceneManagement 命名空间
        }
    }
}
