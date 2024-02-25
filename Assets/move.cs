using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour

{


    [SerializeField]
    private KeyCode leftKey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow, space = KeyCode.Space;

    [SerializeField]
    private Rigidbody2D rgbd;
    [SerializeField]
    private SpriteRenderer sprite;

    [SerializeField]
    private Collider2D box_character;
    [SerializeField]
    private Collider2D box_ground;

    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(GetComponent<Collider2D>(), LayerMask.GetMask("ground"));

        if (Input.GetKey(leftKey))
        {
            rgbd.AddForce(Vector2.left * 3);
        }
        if (Input.GetKey(rightKey))
        {
            rgbd.AddForce(Vector2.right * 3);
        }
        if (Input.GetKeyDown(space) && isGrounded)
        {
            rgbd.AddForce(Vector2.up * 300);
        }


    }
    public bool facingLeft = true; 

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        if (h > 0 && facingLeft)
            Flip();
        else if (h < 0 && !facingLeft)
            Flip();
    }
    void Flip()
    {
        facingLeft = !facingLeft;
        sprite.flipX = !facingLeft;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {        
        if (collision.gameObject.tag == "boing")
        {

            rgbd.AddForce(Vector2.up * 1100);
        }
        if (collision.gameObject.tag == "boing2")
        {

            rgbd.AddForce(Vector2.up * 600);
    }
            if (collision.gameObject.tag == "boing3")
        {

            rgbd.AddForce(Vector2.up * 800);
        }
}
}
