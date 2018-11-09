using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameControl : MonoBehaviour {

    //evento de cambio de color mas poder de B
    public delegate void changeColor();
    public event changeColor miCambiocolor;


    //evento de cambio de movimiento de C 
    public delegate void moverObjeto(int power);
    public event moverObjeto miMove;


    public static GameControl controlador;


    private void Awake()
    {
       if(controlador == null)
        {
            controlador = this;
            DontDestroyOnLoad(this);

        }else if(controlador != this)
        {

            Destroy(gameObject);
        }
    }

    public void actualizaPoder()
    {
        miCambiocolor();
    }

    public void actualizaMover(int power)
    {
        miMove(power);
    }
    // Use this for initialization
    void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		


	}


    /*public void cambioCubo()
    {
        

        GameObject.FindWithTag("B").GetComponent<Renderer>().material.color = Color.yellow;

        Debug.Log("por lo menos entra");
    }*/

    


}
