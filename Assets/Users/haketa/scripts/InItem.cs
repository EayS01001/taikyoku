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
        AnyObject = GameObject.Find("GameObject"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
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
            //プレイヤーの体力を高くする
            script.hp = 100;
            //プレイヤーの攻撃を高くする
            script.defense = 200;
            Destroy(this.gameObject);

        }
    }
}
