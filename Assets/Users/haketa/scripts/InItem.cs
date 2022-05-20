using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InItem : MonoBehaviour
{
    public float seconds = 5;
    public int playerhp;
    public int playerhp2;
    public playerController script;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player1"))
        {
            StartCoroutine("Player1Change");
        }
        if (col.gameObject.CompareTag("Player2"))
        {
            StartCoroutine("Player2Change");
        }
    }

    IEnumerator Player1Change()
    {
        playerhp = script.playerHp;
        //�v���C���[�̗̑͂���������
        script.playerHp = 100;
        //�v���C���[�̍U������������
        script.playerAttack = 200;
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
        script.playerHp = playerhp;
        script.playerAttack = 0;
    }
    IEnumerator Player2Change()
    {

        playerhp2 = script.playerHp;
        //�v���C���[�̗̑͂���������
        script.playerHp = 100;
        //�v���C���[�̍U������������
        script.playerAttack = 200;
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
        script.playerHp = playerhp2;
        script.playerAttack = 0;
    }
}
