using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InItem : MonoBehaviour
{
    public int HPBuff = 200;
    public int AttackBuff = 200;
    private playerController script;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            Destroy(gameObject);
        }
    }
}
