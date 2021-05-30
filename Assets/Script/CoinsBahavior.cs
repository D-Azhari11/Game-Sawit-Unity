using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsBahavior : MonoBehaviour
{
    public int value = 1;
    private GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GameObject.FindGameObjectWithTag("CoinAmount");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Player")){
            GameObject.Find("CoinSound").GetComponent<AudioSource>().Play(0);
			int coinUI = int.Parse(UI.GetComponent<Text>().text) + 1;
			UI.GetComponent<Text>().text = coinUI + "";
            Destroy(gameObject);
	    }
	}
}
