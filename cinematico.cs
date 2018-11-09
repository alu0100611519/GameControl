using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinematico : MonoBehaviour {
    public GameControl theGame;



	// Use this for initialization
	void Start () {
        theGame = GameObject.FindWithTag("paco").GetComponent<GameControl>();
        theGame.miMove += move;
    }


    public void move(int power)
    {

        transform.Translate(Vector3.forward * power);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
