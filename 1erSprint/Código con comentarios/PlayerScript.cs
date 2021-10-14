using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //variable publica de velocidad, será la velocidad con la que se moverá el jugador
    public int vel;

    // Start se llama al iniciar el juego
    void Start()
    {
        
    }

    // Update se llama cada milisegundo
    void Update()
    {
        Movement();
        Interaction();
    }

    //función de movimiento
    public void Movement()
    {
        //si se presiona la flecha de arriba
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //mover el personaje en -z
            transform.position += new Vector3(0, 0, -vel * Time.deltaTime);
        }
        //si se presiona la flecha de abajo
        //es un else if, pues no se puede mover hacia arriba y abajo al mismo tiempo
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //mover el personaje en +z
            transform.position += new Vector3(0, 0, vel * Time.deltaTime);
        }
        //si se presiona la flecha derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //mover el personaje en -x
            transform.position += new Vector3(-vel * Time.deltaTime, 0, 0);
        }
        //si se presiona la flecha izquierda
        //es un else if, pues no se puede mover hacia la derecha e izquierda al mismo tiempo
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //mover el personaje en +x
            transform.position += new Vector3(vel * Time.deltaTime, 0, 0);
        }
        //si se presiona Q
        if (Input.GetKey(KeyCode.Q))
        {   
            //rotar en -y
            transform.Rotate(0.0f, -5.0f, 0.0f, Space.Self);
        }
        //si se presiona E
        else if (Input.GetKey(KeyCode.E))
        {
            //rotar en +y
            transform.Rotate(0.0f, 5.0f, 0.0f, Space.Self);
        }
    }

    //metodo para interactuar
    public void Interaction()
    {
        //si se presina barra espaciadora
        if (Input.GetKey(KeyCode.Space))
        {
            //aqui va el código para la interacción, pero como aun no hay objetos para interactuar, solo hay un print
            Debug.Log("Interacción");
        }
    }
}
