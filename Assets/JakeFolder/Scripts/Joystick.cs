using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems; //Ű����,����,��ġ�� �̺�Ʈ�� ������Ʈ���� ������ �ִ� ����� ����

public class Joystick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField]
    [Range(10f, 150f)]
    private float              m_fLeverRange;
    [SerializeField]
    private RectTransform      m_lever;
    private RectTransform      m_rectTransform;
    private PlayerController[] m_playerController;
    private Player             m_player;   
    private Vector2            m_inputDir;
    private bool               m_bIsInput;

    private void Awake()
    {
        m_rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (true == m_bIsInput)
        {
            InputControlVector();
        }
    }

    public void RoundStart()
    {
        m_playerController = FindObjectsOfType<PlayerController>();

        for (int i = 0; i < m_playerController.Length; i++)
        {
            if (m_playerController[i].photonView.IsMine)
            {
                m_player = m_playerController[i].m_player;
            }
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        JoystickControll(eventData);
        m_bIsInput = true;

        //������Ʈ�� Ŭ���ؼ� �巡���ϴ� ���߿� ������ �̺�Ʈ
        //������ Ŭ���� ������ä�� ���콺�� ���߸� �̺�Ʈ�� ����������
    }

    public void OnDrag(PointerEventData eventData)
    {
        JoystickControll(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        m_lever.anchoredPosition = Vector2.zero;
        m_bIsInput = false;
        //m_playerController.Accelate(Vector2.zero);
        m_player.Move(Vector2.zero);
    }

    private void JoystickControll(PointerEventData eventData)
    {
       // Debug.Log(string.Format("{0} - {1}", eventData.position, m_rectTransform.anchoredPosition));
        var inputPos = eventData.position * (800f / Screen.width) - m_rectTransform.anchoredPosition;
        var inputVector = inputPos.magnitude < m_fLeverRange ? inputPos : inputPos.normalized * m_fLeverRange;
        m_lever.anchoredPosition = inputVector;
        m_inputDir = inputVector / m_fLeverRange;
        // ����������: �� ��ǲ�����ʹ� �ػ󵵷� ����������̶� �ʹ� ũ��. �� ���� 0�� 1������ ����ȭ�� ������ ��ȯ�ϰ�
        // �ػ󵵰� �ٸ� ȯ�濡���� ���� ��ǲ���� �ޱ� ����.
    }

    private void InputControlVector()
    {
        m_player.Move(m_inputDir);
    }
}


