using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinamico : MonoBehaviour {

    public GameControl theGame;
    

	// Use this for initialization
	void Start () {

        theGame = GameObject.FindWithTag("paco").GetComponent<GameControl>();
        

	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Marcial")
        {
            theGame.actualizaPoder();
            Debug.Log("consigue entrar");
        }
    }



    void estaticoPowerUp()
    {
        GameObject.FindWithTag("B").GetComponent<cubo>().powerUp();
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
