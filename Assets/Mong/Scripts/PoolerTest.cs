using ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolerTest : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;

    string Key;
    string Key4 = "�´� ��ƼŬ";


    public Dictionary<string, GameObject> GetDic = new Dictionary<string, GameObject>();

    public PoolManager poolManager;

    // Update is called once per frame
    public void PoolGet(string get)
    {
        Key = "���ݻ���";
        GetDic.Add(Key, poolManager.Get(prefabs[0]));
        Key = "�´»���";
        GetDic.Add(Key, poolManager.Get(prefabs[1]));
        Key = "��������";
        GetDic.Add(Key, poolManager.Get(prefabs[2]));
        Key = "������ƼŬ";
        GetDic.Add(Key, poolManager.Get(prefabs[3]));
        Key = "�´���ƼŬ";
        GetDic.Add(Key4, poolManager.Get(prefabs[4]));

    }
    void Update()
    {
        

        if (Input.GetKey(KeyCode.A))
        {
            //poolManager.Get(prefabs[0]);
            //PoolGet(prefabs[0]);
            //GetDic.TryGetValue(Key, out prefabs[0]);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //poolManager.Get(prefabs[1]);
            //GetDic.TryGetValue(Key1, out prefabs[1]);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //poolManager.Get(prefabs[2]);
            //GetDic.ContainsKey(Key2);
            //GetDic.TryGetValue(Key2, out prefabs[2]);


        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            //poolManager.Get(prefabs[3]);
            //GetDic.ContainsKey(Key3);
            //GetDic.TryGetValue(Key3, out prefabs[3]);


        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            //poolManager.Get(prefabs[4]);
            //GetDic.

            GameObject prefab = poolManager.Get(prefabs[4]);
            GetDic.TryGetValue(Key4, out prefab);

        }
    }
}
