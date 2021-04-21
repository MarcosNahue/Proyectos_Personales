using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ButtonScript : MonoBehaviour
{

    Animator CameraControl;
    int DoFlip;
    public GameObject MainCameraGO;
    //public GameObject ButtonTextGO;
    TextMeshProUGUI ButtonTextPro;
    public GameObject ButtonText;
    public GameObject MainMenuGO;

    void Start()
    {
        CameraControl = MainCameraGO.GetComponent<Animator>();
        //CameraControl.SetBool("CameraFlipBool", false);
        //DoFlip = CameraControl.GetBool("CameraFlipBool");
        CameraControl.SetInteger("FlipAnim", 1);
        DoFlip = CameraControl.GetInteger("FlipAnim");
        ButtonTextPro = FindObjectOfType<TextMeshProUGUI>();

        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfPressed();
    }

    

    void CheckIfPressed()
    {
        if (DoFlip == 0)             //if (CameraControl.GetInteger("FlipAnim") == 1)
        {
            PlayAnimation();
            
        }

    }

    // This is being configured using canvas, button properties and also event system.

    public void ButtonPressed(int ButtonClicked)
    {
        //CameraControl.SetInteger("FlipAnim", 1);
        DoFlip = 0;
        Debug.Log("Clicked");
        HideButton();
        Destroy(ButtonText);
    }

    void PlayAnimation()
    {
        CameraControl.Play("CameraFlip");
    }

    void HideButton()
    {
        GetComponent<Image>().enabled = false;
        ButtonTextPro.text = " ";
        

        //GetComponentInChildren<TextMesh>().text = "Testing";
        //ButtonTextGO.GetComponent<TextMeshPro>().text = "Testing";
    }

    

       
}
