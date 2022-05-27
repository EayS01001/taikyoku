using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
   [SerializeField,Header("�����G�Ə�Q��")] public GameObject[] Blackeobstacle; //�I�u�W�F�N�g���i�[����z��ϐ�
    [SerializeField, Header("�����G�Ə�Q��")] public GameObject[] Whiteobstacle;
    public Transform Maincanvas;
    public float time; //�o������Ԋu�𐧌䂷�邽�߂̕ϐ�
    private float ctime;
    private int bnum; //�����_���������邽�߂̕ϐ�
    private int wnum;
    private int count;

    [SerializeField]
    private float minTime = 1;
    [SerializeField]
    private float maxTime = 3;

    void Start()
    {
        ctime = time;
    }

    void Update()
    {
        time -= Time.deltaTime; //time���玞�Ԃ����炷
        if (time <= 0.0f) //0�b�ɂȂ��
        {
            time = Random.Range(minTime, maxTime);
            bnum = Random.Range(0, Blackeobstacle.Length); //Random.Range (�ŏ��l, �ő�l) �����̏ꍇ�͍ő�l�͏��O
            GameObject Bprefab =  (GameObject)Instantiate(Blackeobstacle[bnum], new Vector2(1200, 52), Quaternion.identity); //X���W-10�Ƀ����_���o���A�����̐ݒ�͖���
            Bprefab.transform.SetParent(Maincanvas, false);
            wnum = Random.Range(0, Whiteobstacle.Length); //Random.Range (�ŏ��l, �ő�l) �����̏ꍇ�͍ő�l�͏��O
            GameObject Wprefab =Instantiate(Whiteobstacle[wnum], new Vector2(908, -491), Quaternion.identity); //X���W-10�Ƀ����_���o���A�����̐ݒ�͖���
            Wprefab.transform.SetParent(Maincanvas, false);
            count++;
        }
        if(count == 10)
        {
            time -= 0.2f;
            count -= 10;
        }
    }



    
}
