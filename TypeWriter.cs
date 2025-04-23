using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //引用UnityEngine.UI命名空间，用于调用UI相关组件

public class TypeWriter : MonoBehaviour
{
    public Text GetText;  //公有变量，用于在编辑器中获取需要显示的文本

    private string GetString = "莫高窟始建于十六国时期，据唐《李克让重修莫高窟佛龛碑》一书的记载,前秦建元二年(366年），僧人乐尊路经此山，忽见金光闪耀，如现万佛，于是便在岩壁上开凿了第一个洞窟。此后法良禅师等又继续在此建洞修禅，称为“漠高窟”,意为“沙漠的高处”。莫高窟开凿于敦煌城东南25公里的鸣沙山东麓的崖壁上，前临宕泉，东向祁连山支脉三危山。南北全长1680米,现存历代营建的洞窟共735个，分布于高15~30多米高的断崖上，上下分布1~4层不等。分为南、北两区，其中南区是礼佛活动的场所，各个朝代壁画和彩塑的洞窟492个，彩塑2400多身，壁画4.5万多平方米，唐宋时代木构窟檐五座，还有民国初重修的作为莫高窟标志的九层楼。";  //用于存放需要显示的文本

    private void Awake()
    {
        StartCoroutine(Typing());  //启用协程
    }

    IEnumerator Typing()
    {
        for (int i = 0; i < GetString.Length; i++)  //循环
        {
            GetText.text += GetString[i];  //逐个输出保存在GetString变量中的文字
            yield return new WaitForSeconds(0.1f);  //每输出一个字，等待0.1秒
            
        }
    }
}