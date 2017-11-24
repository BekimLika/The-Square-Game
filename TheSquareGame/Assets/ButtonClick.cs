using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonClick : MonoBehaviour
{

	public void NewGameBtn(string NewGameLevel)
    {
        SceneManager.LoadScene(NewGameLevel);
    }

    public void ExitBtn()
    {
        Application.Quit();
    }

    public void Option()
    {
        
    }

}
