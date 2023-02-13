using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DragonAttack : MonoBehaviourPun
{
    // �巡���� 4���� ��ŸƮ ���� �߿� �� ���� �������� ��ġ�ϰ� �Ǿ� ���� ������ ���ư��� �� �� �ٽ� ���� ��ġ�� ������ �� �ٽ� ���� ����
    // �ڷ�ƾ + translate + trigger ??
    public GameObject[] attackPosition = new GameObject[4];
    //public GameObject[] TrainbPosition = new GameObject[2];
    public Dragon m_dragon;
    public float dragonTime;
    public float m_fVelocity;
    

    private void Start()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            Destroy(this);
        }
            StartCoroutine(DragonAttackStart());

        m_dragon.m_rigidbody.velocity = transform.forward*m_fVelocity;
    }

    private void Update()
    {
        //dragon.transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);

        m_dragon.m_rigidbody.velocity = m_dragon.transform.forward * m_fVelocity;

    }



    public IEnumerator DragonAttackStart()
    {

        yield return new WaitForSeconds(10f);


        while (true)
        {
            yield return new WaitForSeconds(dragonTime);
            int q = Random.Range(0, 4);
            m_dragon.transform.position = attackPosition[q].transform.position;
            m_dragon.transform.rotation = attackPosition[q].transform.rotation;
        }
    }



   
}

