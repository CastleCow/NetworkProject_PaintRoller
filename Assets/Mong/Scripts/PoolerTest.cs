using ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class PoolerTest : MonoBehaviour
{
    [SerializeField]
    private GameObject[] prefabs;

    string Key;

    public Dictionary<string, GameObject> GetDic = new Dictionary<string, GameObject>();

    public PoolManager poolManager;
    // Update is called once per frame
    private void PoolAdd()
    {
        Key = "���ݻ���";
        GetDic.Add(Key, poolManager.Get(prefabs[0]));
        Key = "�ǰݻ���";
        GetDic.Add(Key, poolManager.Get(prefabs[1]));
        Key = "��������";
        GetDic.Add(Key, poolManager.Get(prefabs[2]));
        Key = "������ƼŬ";
        GetDic.Add(Key, poolManager.Get(prefabs[3]));
        Key = "�ǰ���ƼŬ";
        GetDic.Add(Key, poolManager.Get(prefabs[4]));
    }
    private void PoolGet(string get)
    {
        Key = get;
        poolManager.NameGet(Key);
    }
    private void Start()
    {
        PoolAdd();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //poolManager.Get(prefabs[0]);
            //PoolGet(prefabs[0]);
            //GetDic.TryGetValue(Key, out prefabs[0]);
            PoolGet("�ǰ���ƼŬ"); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            //poolManager.Get(prefabs[1]);
            //GetDic.TryGetValue(Key1, out prefabs[1]);
            PoolGet("AttackParticle");

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            poolManager.Get(prefabs[2]);

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
           
        }
    }
}
