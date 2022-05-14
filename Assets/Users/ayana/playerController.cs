using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 100f;
    [SerializeField]
    private float JumpForce = 0;
    private Rigidbody2D momo;

    [SerializeField]
    private bool isGround = false;


    // Start is called before the first frame update

    private void Awake()
    {
        momo = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if(Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }
    
    /// <summary>
    /// à⁄ìÆÇ∑ÇÈèàóù
    /// </summary>
    private void Move()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed, 0, 0);
    }

    private void Jump()
    {
        if(isGround == true)
        {
            momo.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.tag == "Grounds")
        {
            isGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "Grounds")
        {
            isGround = false;
        }
    }
}
