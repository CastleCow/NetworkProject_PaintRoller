namespace Jake {

    using Photon.Pun;
    using Photon.Pun.UtilityScripts;
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MasterGroundChecker : MonoBehaviourPun
    {

     
        public float m_fTeam;
        public CubeManager m_cubeManager;

        private void Start()
        {
            m_cubeManager = GameObject.Find("SubwayMap").GetComponent<CubeManager>();
        }
        private void OnTriggerEnter(Collider other)
        {


            // ���߿� �̺�Ʈ�� ���� ������� ��ĥ ���ִ°ɷ� ���� ���� 
            if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
            photonView.RPC("GroundCheck", RpcTarget.MasterClient, other,m_fTeam);
               
            }
        }

        [PunRPC]
        public void GroundCheck(Collider other, float team)
        {
          
                GroundColorChange newGroundColorChange=other.gameObject.GetComponent<GroundColorChange>();
                float number= newGroundColorChange.m_fNumber;
                m_cubeManager.Paint(number,team);

        }

    }





}
