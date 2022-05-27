using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{    
    [SerializeField]
    private bool isGround = false;
    [SerializeField]
    private GameObject Bullet;
    [SerializeField]
    private float MoveSpeed = 100f;
    [SerializeField]
    private float JumpForce = 0;
    [SerializeField]
    private float CoolDownTime = 3;
    [SerializeField]
    private float flashSpeed = 3;

    private Rigidbody2D momo;
    private bool canAttack = false;
    private bool isInvincible = false;

    Renderer rend;

    public int playerHp = 2;
    public int playerAttack = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        momo = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        canAttack = true;
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

        if(isInvincible==true)
        {
            flash();
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            var itemsprict = collision.gameObject.GetComponent<InItem>();
            StartCoroutine(Buff(itemsprict.HPBuff, itemsprict.AttackBuff));
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
        if (canAttack == true)
        {
            Instantiate(Bullet,transform.position, Quaternion.identity);            
            canAttack = false;
            StartCoroutine(ResetCoolDownTime());
        }
    }

    IEnumerator ResetCoolDownTime()
    {
        yield return new WaitForSeconds(CoolDownTime);
        canAttack = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Del")
        {
            if (this.gameObject.tag == "Player1")
            {
                SceneManager.LoadScene("WhiteWin");
            }
            else if (this.gameObject.tag == "Player2")
            {
                SceneManager.LoadScene("BlackWin");
            }
        }
    }
    public IEnumerator Buff(int HpBuffValue,int AttackBuffValue)
    {
        isInvincible = true;
        int beforeHP = playerHp;
        playerHp = HpBuffValue;
        //ÉvÉåÉCÉÑÅ[ÇÃçUåÇÇçÇÇ≠Ç∑ÇÈ
        playerAttack = AttackBuffValue;
        yield return new WaitForSeconds(2.0f);
        playerHp = beforeHP;
        playerAttack = 0;
        isInvincible = false;
    }

    public bool SubHP(int Damage)
    {
        bool isDie = false;
        playerHp -= Damage;
        if(playerHp <= 0)
        {
            isDie = true;
        }    
        return isDie;
    }

    private void flash()
    {
        Color lerpedColor = Color.white;
        lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time * flashSpeed, 1));
        rend.material.color = lerpedColor;
    }
}
