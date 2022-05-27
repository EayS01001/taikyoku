using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
   [SerializeField,Header("黒い敵と障害物")] public GameObject[] Blackeobstacle; //オブジェクトを格納する配列変数
    [SerializeField, Header("白い敵と障害物")] public GameObject[] Whiteobstacle;
    public Transform Maincanvas;
    public float time; //出現する間隔を制御するための変数
    private float ctime;
    private int bnum; //ランダム情報を入れるための変数
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
        time -= Time.deltaTime; //timeから時間を減らす
        if (time <= 0.0f) //0秒になれば
        {
            time = Random.Range(minTime, maxTime);
            bnum = Random.Range(0, Blackeobstacle.Length); //Random.Range (最小値, 最大値) 整数の場合は最大値は除外
            GameObject Bprefab =  (GameObject)Instantiate(Blackeobstacle[bnum], new Vector2(1200, 52), Quaternion.identity); //X座標-10にランダム出現、向きの設定は無し
            Bprefab.transform.SetParent(Maincanvas, false);
            wnum = Random.Range(0, Whiteobstacle.Length); //Random.Range (最小値, 最大値) 整数の場合は最大値は除外
            GameObject Wprefab =Instantiate(Whiteobstacle[wnum], new Vector2(908, -491), Quaternion.identity); //X座標-10にランダム出現、向きの設定は無し
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
