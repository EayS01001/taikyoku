using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveObject : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed;
    [SerializeField]
    private int Damage = 1;
    
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
        if(collision.gameObject.tag=="Player1"||collision.gameObject.tag=="Player2")
        {
            if(collision.gameObject.GetComponent<playerController>().SubHP(Damage) == true)
            {
                if(collision.gameObject.tag == "Player1")
                {
                    SceneManager.LoadScene("WhiteWin");
                }
                else if(collision.gameObject.tag == "Player2")
                {
                    SceneManager.LoadScene("BlackWin");
                } 
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
