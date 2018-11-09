using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubo : MonoBehaviour {

    public GameControl theGame;
    public Text text_; // contador
    
    private static int  power = 0;

	// Use this for initialization
	void Start () {
        theGame = GameObject.FindWithTag("paco").GetComponent<GameControl>();
        theGame.miCambiocolor += powerUp;

    }
	

    public void powerUp()
    {

        power += 1 ;
        transform.GetComponent<Renderer>().material.color = Color.yellow;
        text_.text = power.ToString();
        
         
    }
	// Update is called once per frame
	void Update () {
		
	}


    public void OnCollisionEnter(Collision collision)
    {
        theGame.actualizaMover(power);
    }


    public int getPower()
    {
        return power;
    }

}
