using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDetroy : MonoBehaviour
{
   
    [Header("�v���C���[�̔���")] public PlayerTriggerCheck playerCheck;

    // Update is called once per frame
    void Update()
    {
        //�v���C���[��������ɓ�������
        if (playerCheck.isOn)
        {
            
            {
                Destroy(this.gameObject);
            }
        }
    }
}
