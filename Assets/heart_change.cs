using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart_change : MonoBehaviour
{
    public HEALTH curhealth;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        //spriteR.sprite = sprites[spriteVersion];
    }

    // Update is called once per frame
    void Update()
    {
        lifebar();
    }
    void lifebar()
    {
        Debug.Log("Start");
        if (curhealth.getcurhealth() >= 3)
        {
            Debug.Log("3HP");
            anim.Play("3hp");
        }
        if (curhealth.getcurhealth() == 2)
        {
            Debug.Log("2HP");
            anim.Play("2hp");
        }
        if (curhealth.getcurhealth() == 1)
        {
            Debug.Log("1HP");
            anim.Play("1hp");
        }
        if (curhealth.getcurhealth() <= 0)
        {
            Debug.Log("0HP");
            anim.Play("0hp");
        }
    }
}
