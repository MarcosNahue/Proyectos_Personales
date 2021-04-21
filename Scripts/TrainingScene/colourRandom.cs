using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class colourRandom : MonoBehaviour
{
    public bool changeLight = false;
    
    public PostProcessVolume redColour;
    public PostProcessVolume yellowColour;
    public PostProcessVolume greenColour;
  
   public int randomNum;
   private float timer = 2.5f;
    private bool IsPressingBool = false;


    void Update()
    {   
        CountdownChecker();
        ChangeLight();
        ProhibitedChecker();
        IsPressingChecker();
    }



   private void ChangeLight()
    {
        
        if (randomNum == 2)   // RED
        {
            redColour.enabled = true;
            yellowColour.enabled = false;
            greenColour.enabled = false;
        }

        
        
        
        if (randomNum == 1) // GREEN
        {
            redColour.enabled = false;
            yellowColour.enabled = false;
            greenColour.enabled = true;
        }

    }

    void CountdownChecker()
    {
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
            //print(timer);           
        
        }

        if (timer <= 0.0f)
        {
            changeLight = true;
            timer = 2.5f;
        }


        if (changeLight == true)
        {   
            ChoosingColour();
      
        }
    }

    void RandomNumberMaker()
    {
        randomNum = Random.Range(0,3);
        changeLight = false;
    }

    void ChoosingColour()
    {
        randomNum = 0;
        
            redColour.enabled = false;
            yellowColour.enabled = true;
            greenColour.enabled = false;
            
            RandomNumberMaker();

    }

    void ProhibitedChecker()
    {
        if (IsPressingBool == true && randomNum == 2)
        {
            SceneManager.LoadScene("Training");
        }
    }

    void IsPressingChecker()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            IsPressingBool = true;
        }
        else
        {
            IsPressingBool = false;
        }

        
    }
}
