using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmove : MonoBehaviour
{
    public int speed = 100;
    public int jump = 100;
    private Rigidbody2D rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rg.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
    }
}
