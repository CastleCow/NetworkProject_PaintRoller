using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAttack : MonoBehaviour
{
    // �巡���� 4���� ��ŸƮ ���� �߿� �� ���� �������� ��ġ�ϰ� �Ǿ� ���� ������ ���ư��� �� �� �ٽ� ���� ��ġ�� ������ �� �ٽ� ���� ����
    // �ڷ�ƾ + translate + trigger ??
    public GameObject[] attackPosition = new GameObject[4];
    public GameObject[] TrainbPosition = new GameObject[2];
    public GameObject dragon;
    public float dragonTime;
    public float speed;

    private void Update()
    {
        StartCoroutine(DragonAttackStart());
        dragon.transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);
    }

    public IEnumerator DragonAttackStart()
    {
        yield return new WaitForSeconds(dragonTime);
        int q = Random.Range(0, 4);
        dragon.transform.position = attackPosition[q].transform.position;
        dragon.transform.rotation = attackPosition[q].transform.rotation;
        StopAllCoroutines();
    }

   
}
