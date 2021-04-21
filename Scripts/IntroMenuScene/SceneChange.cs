using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{

    public void btn_change_scene(string Training)
    {
        SceneManager.LoadScene(Training);
    }


}

