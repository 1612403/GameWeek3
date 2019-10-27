using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMove : MonoBehaviour
{
    public float speed = 7.0f;
    public float jump = 300.0f;
    int canJump = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && canJump < 2)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
            GetComponent<Animator>().SetTrigger("Run");
            canJump++;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = 0;
    }
}
