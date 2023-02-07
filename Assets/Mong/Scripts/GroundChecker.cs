using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundChecker : MonoBehaviour
{
    public enum PlayerType { Player, Enermy };
    public PlayerType playerType;
    //Ʈ���Ÿ� �������� ��ü �غ�����
    private void OnTriggerEnter(Collider other)
    {
        // ���߿� �̺�Ʈ�� ���� ������� ��ĥ ���ִ°ɷ� ���� ���� 
        if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            if (playerType == PlayerType.Player)
                other.gameObject.GetComponent<GroundColorChange>().renderer.material.color = Color.red;
            else
                other.gameObject.GetComponent<GroundColorChange>().renderer.material.color = Color.blue;
        }
    }

}
