using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //-x座標に移動し続ける
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime*3;
    }

    //コライダー2dを持つオブジェクトと衝突したらログが出る
    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Hit"); // ログを表示する

    }
}
