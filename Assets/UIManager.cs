using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{ 
    
    public GameObject win;
    public GameObject fail;
    public Text Skortext;
    
    public void restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }
    void Start()
    {
        
    }

    void Update()
    {
        Skortext.text="SCORE= "+ moving.instance.totalcount.ToString();
        if (moving.instance.totalcount < 0)
        {
            fail.SetActive(true);
        }
        if (moving.instance.totalcount == 120)
        {
            win.SetActive(true);
        }
    }
}
