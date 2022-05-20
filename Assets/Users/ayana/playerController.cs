using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 100f;
    [SerializeField]
    private float JumpForce = 0;
    private Rigidbody2D momo;

    [SerializeField]
    private bool isGround = false;
    [SerializeField]
    private GameObject Bullet;
    public int playerHp = 2;
    public int playerAttack = 0;


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

        if(Input.GetKeyDown(KeyCode.W)&&transform.tag=="Player1")
        {
            Jump();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && transform.tag == "Player2")
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.S) && transform.tag == "Player1")
        {
            Attack();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.tag == "Player2")
        {
            Attack();
        }
    }
    
    /// <summary>
    /// à⁄ìÆÇ∑ÇÈèàóù
    /// </summary>
    private void Move()
    {
        if(transform.tag == "Player1")
            transform.position += new Vector3(Input.GetAxis("Horizontal2") * Time.deltaTime * MoveSpeed, 0, 0);
        if(transform.tag == "Player2")
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed, 0, 0);
        }
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
    void Attack()
    {
        Instantiate(Bullet,transform.position, Quaternion.identity);
    }

    void OnBecameInvisible()
    {
        if(transform.tag == "Player2")
        {
            SceneManager.LoadScene("WhiteWin");
        }
        else if(transform.tag == "Player1")
        {
            SceneManager.LoadScene("BlackWin");
        }
    }
}
