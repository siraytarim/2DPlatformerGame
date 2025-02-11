using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KarakterHareket : MonoBehaviour
{
    public float horizontalmove;
    public int movingspeed;
    public int jumpingspeed;
    public int zıplamahakkı;


    Rigidbody2D rb;

    public bool characterfloor;
    public bool faceright = true;

    public GameObject karakter;
    public GameObject griküp;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        zıplamahakkı = 2;
    }

    void Update()
    {
        horizontalmove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalmove * movingspeed * 100 * Time.deltaTime, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && (characterfloor == true || zıplamahakkı > 0))
        {
            rb.velocity = Vector2.up * jumpingspeed * 100 * Time.deltaTime;
            characterfloor = false;
            zıplamahakkı -= 1;

        }

        if (horizontalmove > 0 && faceright == false)  //horizontalmove > 0 : sağa hareket ediyor
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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            characterfloor = true;
            zıplamahakkı = 2;
        }

        if (collision.gameObject.tag == "griküp")
        {
            karakter.SetActive(false);

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
