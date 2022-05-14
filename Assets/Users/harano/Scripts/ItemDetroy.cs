using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDetroy : MonoBehaviour
{
   
    [Header("プレイヤーの判定")] public PlayerTriggerCheck playerCheck;

    // Update is called once per frame
    void Update()
    {
        //プレイヤーが判定内に入ったら
        if (playerCheck.isOn)
        {
            
            {
                Destroy(this.gameObject);
            }
        }
    }
}
