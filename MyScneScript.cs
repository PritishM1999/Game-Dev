using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using Button = UnityEngine.UI.Button;

public class MyScneScript : MonoBehaviour
{
    public Button button;
    public string SecondScene;
    //public string ThirdScene;

    //public Button button;
    //public string BackScene1;
    //public string BackScene2;

    public void Start()
    {
       button.onClick.AddListener(OnButtonClick);
       //SceneManager.LoadScene(ThirdScene);
    }
    private void OnButtonClick()
    {
        Debug.Log("Button clicked");
        SceneManager.LoadScene(SecondScene);
        //SceneManager.LoadScene(ThirdScene);
        //SceneManager.LoadScene(ThirdScene);
    }
}
