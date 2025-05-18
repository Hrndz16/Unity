using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]// permite que la variable private aparesca en unity y sea modificable
    private float speed = 5f;

    public float HorizontalInput;// para mover de manera en x con solo las teclas a y d
    public float VerticalInput;// para mover de manera en y con solo las teclas w y s
    public GameObject miObjeto;
    public GameObject miOtrobjeto;

    public bool cambiaObjeto = false;
    Quaternion rotacion = Quaternion.Euler(0f, 0f, 0f);

    void Start()
    {


    }
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");// te mueves en x
        transform.Translate(Vector3.right * Time.deltaTime * speed * HorizontalInput);
        VerticalInput = Input.GetAxis("Vertical"); // te mueves en y 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        Debug.Log(transform.position);

        // LIMITES DEL ESENARIO VERTICAL
        if (transform.position.x > 5f)
        {
            transform.position = new Vector3(5f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -5.2f)
        {
            transform.position = new Vector3(-5f, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -7f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -7f);
        }
        if (transform.position.z >= 7f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 7f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiaMiObjeto();


        }


    }
    private void CambiaMiObjeto()
    {
        if (cambiaObjeto == true)
        {
            Instantiate(miOtrobjeto, transform.position, rotacion);
        }
        else
        {
            Instantiate(miObjeto, transform.position, rotacion);
        }
    }
    
}
