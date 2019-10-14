using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public Button button;
	// Use this for initialization
	void Start () {
        button.onClick.AddListener(onClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void onClick()
    {
        SceneManager.LoadScene("mainMenu");
    }
}
