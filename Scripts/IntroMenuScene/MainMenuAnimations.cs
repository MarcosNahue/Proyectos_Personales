using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimations : MonoBehaviour
{
    Animator mainmenuAnimator;
    int ShowButtonsInt;
    //public GameObject CameraGO;
    //public GameObject MenuGO;
    //public Vector3 CameraRotation;
    // public Vector3 ExpectedRotation;
    //public float xRotation;
    // public float xExpectedRotation;
    bool MenuActive = false;
    
    void Start()
    {
        mainmenuAnimator = GetComponent<Animator>();     
        mainmenuAnimator.SetInteger("ShowButtons_Parameter", 1); 
        ShowButtonsInt = mainmenuAnimator.GetInteger("ShowButtons_Parameter");
        //CameraRotation = CameraGO.GetComponent<Vector3>();
        // CameraRotation = CameraGO.GetComponent<Vector3>();
        // xExpectedRotation = ExpectedRotation.x; //<--Until here working
        mainmenuAnimator.Play("MainButtons");
        MenuActive = true;
       
    }

    

    void Update()
    {
        // CHANGE CheckIfPressedMain();
        // CHANGE CheckBoolMain();
       // xRotation = CameraRotation.x;
    }

    void CheckIfPressedMain()
    {
        if (ShowButtonsInt == 0)                                 
        {
            PlayAnimationMain();
            //print("Should play buttons anim");
        }
    }



    public void ButtonPressedMain()
    {
        ShowButtonsInt = 0;
                  
    }

    void PlayAnimationMain()
    {
        mainmenuAnimator.Play("MainButtons");
    }

   /* CHANGE public void CheckBoolMain()
    {
        if (MenuActive == true)
        {
            ButtonPressedMain();

        }
        //xRotation = CameraRotation.x;
    }
    */
 
}
