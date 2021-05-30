using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour {


	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Text>().text = "0";
		//gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinsAmount") + "";
	}

    void Update(){
        if(Input.GetKeyDown("a")){
            Debug.Log("Tresore Sauvagerde");
            PlayerPrefs.SetInt("CoinsAmount", int.Parse(gameObject.GetComponent<Text>().text));
        }
    }

    public void SaveCoin(){
        int coinAlreadyCollected = PlayerPrefs.GetInt("CoinsAmount");
        // PlayerPrefs.SetInt("CoinsAmount",coinAlreadyCollected + int.Parse(gameObject.GetComponent<Text>().text));
        PlayerPrefs.SetInt("CoinsAmount",int.Parse(gameObject.GetComponent<Text>().text));
    }
}
