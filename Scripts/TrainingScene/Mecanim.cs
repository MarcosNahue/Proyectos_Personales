using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanim : MonoBehaviour
{

    public Animator animController;

    void Start()
    {
        animController = GetComponent<Animator>();
        animController.SetInteger("Advance", 0);
        animController.SetInteger("Idle", 0);
    }

    //Idle = 0 positive, 1 negative.
    //Advance = 0 negative, 1 positive.

    void Update()
    {
        Advance();
        Idle();
    }


    // animaciones

    void Advance()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

            animController.SetInteger("Advance", 1);
            animController.SetInteger("Idle", 1);
        }
        else
        {
            animController.SetInteger("Advance", 0);
        }
    }

    void Idle()
    {
        if(animController.GetInteger("Advance") == 0)
        {
            animController.SetInteger("Idle", 0);
        }
    }
}
