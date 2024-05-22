using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharacter : MonoBehaviour
{

    public GameObject grik�p;
   
    public GameObject panel;
    public GameObject karakter;


    public float horizontalmove;
    int movspeed=0;
     int jumpspeed=0;
    public int z�plamahakk�;

    Rigidbody2D rb;

    public bool characterfloor;
    public bool faceright = true;


   public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        z�plamahakk� = 2;
    }

    public void Update()
    {
        horizontalmove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalmove * movspeed * 100 * Time.deltaTime, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && (characterfloor == true || z�plamahakk� > 0))
        {
            rb.velocity = Vector2.up * jumpspeed * 100 * Time.deltaTime;
            characterfloor = false;
            z�plamahakk� -= 1;

        }

        if (horizontalmove > 0 && faceright == false)  //horizontalmove > 0 : sa�a hareket ediyor
        {
            turn();
        }

        if (horizontalmove < 0 && faceright == true)     //horizontalmove < 0 : sola hareket ediyor
        {
            {
                turn();
            }
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            characterfloor = true;
            z�plamahakk� = 2;
        }
        if(collision.gameObject.tag == "character")
        {
            movspeed = 12;
            jumpspeed = 14;
        }

       

    }

    void turn()
    {
        faceright = !faceright;
        Vector2 newscale = transform.localScale;
        newscale.x *= -1;
        transform.localScale = newscale;
    }


   



}
