using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //����UnityEngine.UI�����ռ䣬���ڵ���UI������

public class TypeWriter : MonoBehaviour
{
    public Text GetText;  //���б����������ڱ༭���л�ȡ��Ҫ��ʾ���ı�

    private string GetString = "Ī�߿�ʼ����ʮ����ʱ�ڣ����ơ����������Ī�߿߷��豮��һ��ļ���,ǰ�ؽ�Ԫ����(366�꣩��ɮ������·����ɽ�����������ҫ������������Ǳ����ұ��Ͽ����˵�һ�����ߡ��˺�����ʦ���ּ����ڴ˽�����������Ϊ��Į�߿ߡ�,��Ϊ��ɳĮ�ĸߴ�����Ī�߿߿����ڶػͳǶ���25�������ɳɽ��´���±��ϣ�ǰ���Ȫ����������ɽ֧����Σɽ���ϱ�ȫ��1680��,�ִ�����Ӫ���Ķ��߹�735�����ֲ��ڸ�15~30���׸ߵĶ����ϣ����·ֲ�1~4�㲻�ȡ���Ϊ�ϡ�����������������������ĳ��������������ڻ��Ͳ��ܵĶ���492��������2400�����ڻ�4.5���ƽ���ף�����ʱ��ľ������������������������޵���ΪĪ�߿߱�־�ľŲ�¥��";  //���ڴ����Ҫ��ʾ���ı�

    private void Awake()
    {
        StartCoroutine(Typing());  //����Э��
    }

    IEnumerator Typing()
    {
        for (int i = 0; i < GetString.Length; i++)  //ѭ��
        {
            GetText.text += GetString[i];  //������������GetString�����е�����
            yield return new WaitForSeconds(0.1f);  //ÿ���һ���֣��ȴ�0.1��
            
        }
    }
}