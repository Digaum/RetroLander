using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosaoAnimatorControllerHelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TerminouAnimacao()
    {
        GameController gc = GameObject.FindWithTag("GameController").GetComponent<GameController>();
        gc.OnGameOver();
    }
}
