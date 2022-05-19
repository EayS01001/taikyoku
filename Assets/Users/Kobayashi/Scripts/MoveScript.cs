using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rg.AddForce(new Vector2(speed, 0));
    }

}
