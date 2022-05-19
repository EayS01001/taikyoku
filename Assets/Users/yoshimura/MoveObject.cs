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
        //-x���W�Ɉړ���������
        transform.position += new Vector3(MoveSpeed, 0, 0) * Time.deltaTime;
    }

    //�R���C�_�[2d�����I�u�W�F�N�g�ƏՓ˂����烍�O���o��
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            SceneManager.LoadScene("WhiteWin");
        }
    }
}
