using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InItem : MonoBehaviour
{
    public float seconds = 5;
    public GameObject AnyObject;
    public int playerhp;
    TestPlayer script;

    // Start is called before the first frame update
    void Start()
    {
        AnyObject = GameObject.Find("GameObject"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        script = AnyObject.GetComponent<TestPlayer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            script.hp = playerhp;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            playerhp = script.hp;
            //�v���C���[�̗̑͂���������
            script.hp = 100;
            //�v���C���[�̍U������������
            script.defense = 200;
            Destroy(this.gameObject);

        }
    }
}
