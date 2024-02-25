using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HEALTH : MonoBehaviour

{


    public int curHealth;
    public int maxHealth = 3;
    private Rigidbody2D rgbd;
    float upspead;
    public int getcurhealth()
    {
        return curHealth;
    }


    void Start()
    {
        curHealth = maxHealth;
        Debug.Log("Start");
    }


    [System.Obsolete]
    void Update()
    {

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if (curHealth <= 0)
        {

            Die();
        }
    }

    [System.Obsolete]
    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);


    }


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {

            curHealth -= 1;
        }
                if (collision.gameObject.tag == "oneshot")
        {

            curHealth -= 3;
        }
    }


}

