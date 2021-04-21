using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuToggle : MonoBehaviour
{

   public GameObject MainMenuGO;


    public void MenuChecker()
    {
        if (MainMenuGO.activeSelf == false)
        {
            MainMenuGO.SetActive(true);
        }
    }
}
