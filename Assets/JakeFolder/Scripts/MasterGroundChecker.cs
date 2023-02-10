using UnityEngine;
using UnityEngine.Events;

namespace Jake
{
    public class MasterGroundChecker : MonoBehaviour
    {
        public UnityEvent<Collider> OnGroundTrigger;

        private void OnTriggerEnter(Collider other)
        {
            
            Debug.Log("��Ʈ���ſ���");
            // ���߿� �̺�Ʈ�� ���� ������� ��ĥ ���ִ°ɷ� ���� ���� 
            if (other.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
                OnGroundTrigger?.Invoke(other);
                Debug.Log("������");
            }
        }
    }
}
