namespace Jake
{

    using Photon.Pun;
    using Photon.Pun.UtilityScripts;
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MasterGroundChecker : MonoBehaviourPun
    {

     
        
       
        public PlayerController m_playerController;

        private void Start()
        {
            m_playerController = GetComponentInParent<PlayerController>();
           
        }
        private void OnTriggerEnter(Collider other)
        {


            // ���߿� �̺�Ʈ�� ���� ������� ��ĥ ���ִ°ɷ� ���� ���� 
            if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
                m_playerController.GroundCheckCall(other);
               
            }
        }

        
    }





}
