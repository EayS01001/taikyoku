using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveObject : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //-x座標に移動し続ける
        transform.position += new Vector3(MoveSpeed, 0, 0) * Time.deltaTime;
    }

    //コライダー2dを持つオブジェクトと衝突したらログが出る
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            SceneManager.LoadScene("WhiteWin");
        }
    }
}
