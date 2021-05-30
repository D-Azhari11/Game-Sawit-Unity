using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject infoBtn;
    public GameObject infoPanel;
    public GameObject tentangBtn;
    public GameObject tentangPanel;
    public GameObject exitGame;
    private bool isInfo = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void InfoPlay(){
        if(isInfo){
            isInfo=false;
            Time.timeScale = 1;
            infoBtn.SetActive(true);
            infoPanel.SetActive(false);
        }
        else{
            isInfo=true;
            Time.timeScale = 0;
            infoBtn.SetActive(false);
            infoPanel.SetActive(true);
        }
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void TentangPlay(){
        if(isInfo){
            isInfo=false;
            Time.timeScale = 1;
            tentangBtn.SetActive(true);
            tentangPanel.SetActive(false);
        }
        else{
            isInfo=true;
            Time.timeScale = 0;
            tentangBtn.SetActive(false);
            tentangPanel.SetActive(true);
        }
    }
}
