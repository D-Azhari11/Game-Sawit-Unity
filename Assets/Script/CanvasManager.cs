using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public GameObject WinPanel;
    public GameObject coinPanelTxt;
    public GameObject gameOverCoinTxt;
    public GameObject WinCoinTxt;
    public GameObject exitGame1;
    public GameObject exitGame2;
    private bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver(){
        GameObject.Find("LoseSound").GetComponent<AudioSource>().Play(0);
        GameObject.Find("Music").GetComponent<AudioSource>().Stop();
        Time.timeScale = 0;
        coinPanelTxt.GetComponent<CoinAmount>().SaveCoin(); 
        gameOverCoinTxt.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinsAmount") + "";
        gameOverPanel.SetActive(true);
        pauseBtn.SetActive(false);
    }

    public void WinZone(){
        GameObject.Find("winSound").GetComponent<AudioSource>().Play(0);
        GameObject.Find("Music").GetComponent<AudioSource>().Stop();
        Time.timeScale = 0;
        coinPanelTxt.GetComponent<CoinAmount>().SaveCoin(); 
        WinCoinTxt.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinsAmount") + "";
        WinPanel.SetActive(true);
        pauseBtn.SetActive(false);
    }

    public void PausePlay(){
        if(isPause){
            isPause=false;
            Time.timeScale = 1;
            pauseBtn.SetActive(true);
            pausePanel.SetActive(false);
        }
        else{
            isPause=true;
            Time.timeScale = 0;
            pauseBtn.SetActive(false);
            pausePanel.SetActive(true);
        }
    }

    public void ExitGame(){
        Application.Quit();
    }


    public void Restart(){
        Time.timeScale = 1;
        SceneManager.LoadScene("ingame");
    }
}
