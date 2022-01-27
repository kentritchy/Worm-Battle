using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRb;

    public float horizontalSpeed;
    public float x = 0f;

    public float xMin;
    public float xMax;


    public bool facingRight = false;

    public RightKey rightKey;
    public LeftKey leftKey;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        facingRight = true;
        rightKey = FindObjectOfType<RightKey>();
        leftKey = FindObjectOfType<LeftKey>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(x, 0, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xMin, xMax), transform.position.y, transform.position.z);
        Flip(x);
    }


    public void MoveRight()
    {
        {

            transform.Translate(1 * horizontalSpeed * Time.deltaTime, 0, 0);


            if (!rightKey.Pressed)
            {
                playerRb.velocity = Vector2.zero;
            }
        }
    }
       
    
    public void MoveLeft ()
    {
        {
            transform.Translate(1 * -horizontalSpeed * Time.deltaTime, 0, 0);


            if (!leftKey.Pressed)
            {
                playerRb.velocity = Vector2.zero;
            }

        }
    }


    void Flip(float x)
    {
        {
            if (rightKey.Pressed && !facingRight || leftKey.Pressed && facingRight)
            {
                facingRight = !facingRight;
                Vector3 theScale = transform.localScale;
                theScale.x *= -1;
                transform.localScale = theScale;
            }
        }
    }
}
